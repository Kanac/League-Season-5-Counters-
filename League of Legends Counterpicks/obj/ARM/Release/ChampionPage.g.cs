﻿

#pragma checksum "C:\Users\Anthony C\Documents\Visual Studio 2015\Projects\League of Legends Counterpicks\League of Legends Counterpicks\ChampionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "32EFBEF6473B84E96E2EE5FC695C4734"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace League_of_Legends_Counterpicks
{
    partial class ChampionPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 194 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CounterUpvote_Tapped;
                 #line default
                 #line hidden
                #line 195 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.CounterUpvote_DataLoaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 206 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CounterDownvote_Tapped;
                 #line default
                 #line hidden
                #line 207 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.CounterDownvote_DataLoaded;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 142 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Comment_Flyout;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 145 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)(target)).Closed += this.Comment_FlyoutClosed;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 182 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Submit_CounterComment;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 93 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.CounterCommentUpvote_DataLoaded;
                 #line default
                 #line hidden
                #line 94 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CounterCommentUpvote_Tapped;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 105 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.CounterCommentDownvote_DataLoaded;
                 #line default
                 #line hidden
                #line 106 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.CounterCommentDownvote_Tapped;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 39 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.Upvote_DataLoaded;
                 #line default
                 #line hidden
                #line 40 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Upvote_Tapped;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 51 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.Downvote_DataLoaded;
                 #line default
                 #line hidden
                #line 52 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Downvote_Tapped;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 357 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.StatPage_Navigate;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 319 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.Filter_GotFocus;
                 #line default
                 #line hidden
                #line 321 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.Filter_TextChanged;
                 #line default
                 #line hidden
                break;
            case 12:
                #line 333 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.Filter_Click;
                 #line default
                 #line hidden
                break;
            case 13:
                #line 350 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Submit_Counter;
                 #line default
                 #line hidden
                break;
            case 14:
                #line 258 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.Name_Focus;
                 #line default
                 #line hidden
                break;
            case 15:
                #line 272 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Send_Feedback;
                 #line default
                 #line hidden
                break;
            case 16:
                #line 552 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SynergyChamp_Tapped;
                 #line default
                 #line hidden
                #line 553 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.Synergy_Loaded;
                 #line default
                 #line hidden
                break;
            case 17:
                #line 494 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.EasyMatchup_Tapped;
                 #line default
                 #line hidden
                break;
            case 18:
                #line 446 "..\..\..\ChampionPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Champ_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


