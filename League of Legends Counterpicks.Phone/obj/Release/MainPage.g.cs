﻿

#pragma checksum "C:\Users\Anthony\documents\visual studio 2013\Projects\League of Legends Counterpicks\League of Legends Counterpicks\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "147BDFAF8A180F0796D1F562EC3CB9D4"
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
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 17 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Share_Clicked;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 22 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Tweet;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 25 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ChangeLog_Clicked;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 72 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.GroupSection_ItemClick;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 58 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.FilterBox_GotFocus;
                 #line default
                 #line hidden
                #line 59 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).TextChanged += this.FilterBox_TextChanged;
                 #line default
                 #line hidden
                #line 60 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).SuggestionChosen += this.FilterBox_SuggestionChosen;
                 #line default
                 #line hidden
                #line 61 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.KeyDown_Event;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

