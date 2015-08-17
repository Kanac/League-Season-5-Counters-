﻿using League_of_Legends_Counterpicks.Advertisement;
using League_of_Legends_Counterpicks.Common;
using League_of_Legends_Counterpicks.Data;
using Microsoft.Advertising.Mobile.UI;
using QKit;
using QKit.JumpList;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Storage;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Hub Application template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace League_of_Legends_Counterpicks
{
    public sealed partial class RolePage : Page
    {
        private readonly NavigationHelper navigationHelper;
        private readonly ObservableDictionary defaultViewModel = new ObservableDictionary();
        private ObservableCollection<Role> roles;
        private Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        private readonly String APP_ID = "3366702e-67c7-48e7-bc82-d3a4534f3086";
        private bool firstLoad = true;
        private List<AdControl> adList = new List<AdControl>();
        private DispatcherTimer dispatcherTimer;
        private string roleId, savedRoleId;
        private int sectionIndex;
        private int adRetryCount;

        public RolePage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)  //e is the unique ID
        {
            //Re-sync the timer if page is refreshed (ad will load again - set timer back to 0)
            if (dispatcherTimer != null)
                dispatcherTimer.Stop();

            adRetryCount = 0;
            reviewApp();
            // Check if the navigation paramater changes to determine the roleId to use, otherwise use the roleId set by navigating to ChampionPage
            if ((string)e.NavigationParameter != savedRoleId) {
                roleId = e.NavigationParameter as string;
                savedRoleId = roleId;
            }

            // Gets a reference to all the roles -- no data is seralized again (already done on main page load)
            roles = await DataSource.GetRolesAsync();  
            // Get the 'All' role and configure the view to display the champions nicely
            var allRole = roles[0];
            var GroupedChampions = JumpListHelper.ToAlphaGroups(allRole.Champions, x => x.UniqueId);
            allRole.QkitChampions = GroupedChampions;
            DefaultViewModel["Roles"] = roles;

            // Smoothes out the loading process to get to desired page immedaitely 
            if (roleId == "Filter")
                sectionIndex = MainHub.Sections.Count() - 1;
            else
                sectionIndex = roles.IndexOf(DataSource.GetRole(roleId));
            if (firstLoad)
                MainHub.DefaultSectionIndex = sectionIndex;
            else
                MainHub.ScrollToSection(MainHub.Sections.ElementAt(sectionIndex));
            
            // Set up timer refresh rate of 30 seconds for ads (or use existing one)
            setupAdTimer();
        }
        
        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            // TODO: Save the unique state of the page here.
        }

        /// <summary>
        /// Shows the details of an item clicked on in the <see cref="ChampionPage"/>
        /// </summary>
        /// <param name="sender">The GridView displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
        /// 

        private void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Ask user to purchase ad removal before proceeding
            checkAdRemoval();
            //Store the hub section before proceeding to champion page, so that the back button goes back to it
            roleId = MainHub.SectionsInView[0].Name;

            var championId = ((Champion)e.ClickedItem).UniqueId;
            if (!Frame.Navigate(typeof(ChampionPage), championId))
            {
                var resourceLoader = ResourceLoader.GetForCurrentView("Resources");
                throw new Exception(resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }

        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        //Purpose of this is to load the role page twice since there is a bug with the Qkit jumpList that doesnt render properly on first load
        private void JumpList_Loaded(object sender, RoutedEventArgs e)
        {
            if (firstLoad){
                firstLoad = false;
                var jumpList = sender as AlphaJumpList;
                jumpList.Visibility = Windows.UI.Xaml.Visibility.Visible;
                All.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                All.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MainHub.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                MainHub.Visibility = Windows.UI.Xaml.Visibility.Visible;
                jumpList.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                jumpList.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            String text = (sender as TextBox).Text;
            Role filter = DataSource.FilterChampions(text);
            if (String.IsNullOrEmpty(text))    //Don't show every champion with no query
                DefaultViewModel["Filter"] = null;
            else
                DefaultViewModel["Filter"] = filter;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Text = String.Empty;
        }


        private void Ad_Loaded(object sender, RoutedEventArgs e)
        {
            var ad = sender as AdControl;
            // Check if the ad list already has a reference to this ad before inserting
            if (adList.Where(x => x.AdUnitId == ad.AdUnitId).Count() == 0)
                adList.Add(ad);

            if (App.licenseInformation.ProductLicenses["AdRemoval"].IsActive)
            {
                // Hide the app for the purchaser
                ad.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else
            {
                // Otherwise show the ad
                ad.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }

        private void setupAdTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 33);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            foreach (var ad in adList)
                ad.Refresh();
        }

        private void Ad_Error(object sender, Microsoft.Advertising.Mobile.Common.AdErrorEventArgs e)
        {
            //if (adRetryCount < 5)
            //{
            //    var ad = sender as AdControl;
            //    ad.Refresh();
            //    adRetryCount++;
            //}
        }

        private void GridAd_Loaded(object sender, RoutedEventArgs e)
        {
            var grid = sender as Grid;
            if (App.licenseInformation.ProductLicenses["AdRemoval"].IsActive)
            {
                var rowDefinitions = grid.RowDefinitions;
                foreach (var r in rowDefinitions)
                {
                    if (r.Height.Value == 80)
                    {
                        r.SetValue(RowDefinition.HeightProperty, new GridLength(0));
                    }
                }
            }
        }

        private async void checkAdRemoval()
        {
            if (!App.licenseInformation.ProductLicenses["AdRemoval"].IsActive)
            {
                if (!localSettings.Values.ContainsKey("AdViews"))
                    localSettings.Values.Add(new KeyValuePair<string, object>("AdViews", 3));
                else
                    localSettings.Values["AdViews"] = 1 + Convert.ToInt32(localSettings.Values["AdViews"]);

                int viewCount = Convert.ToInt32(localSettings.Values["AdViews"]);

                //Only ask for IAP purchase up to several times, once every 6 times this page is visited, and do not ask anymore once bought
                if (viewCount % 4 == 0 && viewCount <= 100)
                {
                    var purchaseBox = new MessageDialog("See more counters, easy matchups and synergy picks for each champion at once! Remove ads now!");
                    purchaseBox.Commands.Add(new UICommand { Label = "Yes! :)", Id = 0 });
                    purchaseBox.Commands.Add(new UICommand { Label = "Maybe later :(", Id = 1 });

                    try
                    {
                        var reviewResult = await purchaseBox.ShowAsync();

                        if ((int)reviewResult.Id == 0)
                        {
                            AdRemover.Purchase();
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

        private async void reviewApp()
        {
            if (!localSettings.Values.ContainsKey("Views"))
                localSettings.Values.Add(new KeyValuePair<string, object>("Views", 3));
            else
                localSettings.Values["Views"] = 1 + Convert.ToInt32(localSettings.Values["Views"]);

            int viewCount = Convert.ToInt32(localSettings.Values["Views"]);


            //Only ask for review up to 10 times, once every 5 times this page is visited, and do not ask anymore once reviewed
            if (viewCount % 4 == 0 && viewCount <= 50 && Convert.ToInt32(localSettings.Values["Rate"]) != 1)
            {
                var reviewBox = new MessageDialog("Keep updates coming by rating this app 5 stars to support us!");
                reviewBox.Commands.Add(new UICommand { Label = "Yes! :)", Id = 0 });
                reviewBox.Commands.Add(new UICommand { Label = "Maybe later", Id = 1 });

                try
                {
                    var reviewResult = await reviewBox.ShowAsync();
                    if ((int)reviewResult.Id == 0)
                    {
                        try { await Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + APP_ID)); }
                        catch (Exception) { }
                        localSettings.Values["Rate"] = 1;
                    }
                }
                catch (Exception) { }
            }
        }


        
    }
}