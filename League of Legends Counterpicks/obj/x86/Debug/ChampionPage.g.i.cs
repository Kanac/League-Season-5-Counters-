﻿

#pragma checksum "C:\Users\Anthony C\Documents\Visual Studio 2015\Projects\League of Legends Counterpicks\League of Legends Counterpicks\ChampionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F0B6D70755EF973A36F7B0348113CA8"
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
    partial class ChampionPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Page pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Flyout ChampionFlyout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox FilterBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RadioButton ChampionCounterRadio; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RadioButton ChampionEasyRadio; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RadioButton ChampionSynergyRadio; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Flyout CommentFlyout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock Feedback; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox NameBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox FeedbackBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RadioButton CounterRadio; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RadioButton PlayingRadio; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid LayoutRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid AdGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid AdGrid2; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Pivot MainPivot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem CounterSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem EasyMatchupSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem SynergySection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem CounterCommentSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PivotItem PlayingCommentSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock NoPlayingComments; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock NoCounterComments; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock NoSynergyChampions; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///ChampionPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Windows.UI.Xaml.Controls.Page)this.FindName("pageRoot");
            ChampionFlyout = (global::Windows.UI.Xaml.Controls.Flyout)this.FindName("ChampionFlyout");
            FilterBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("FilterBox");
            ChampionCounterRadio = (global::Windows.UI.Xaml.Controls.RadioButton)this.FindName("ChampionCounterRadio");
            ChampionEasyRadio = (global::Windows.UI.Xaml.Controls.RadioButton)this.FindName("ChampionEasyRadio");
            ChampionSynergyRadio = (global::Windows.UI.Xaml.Controls.RadioButton)this.FindName("ChampionSynergyRadio");
            CommentFlyout = (global::Windows.UI.Xaml.Controls.Flyout)this.FindName("CommentFlyout");
            Feedback = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("Feedback");
            NameBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("NameBox");
            FeedbackBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("FeedbackBox");
            CounterRadio = (global::Windows.UI.Xaml.Controls.RadioButton)this.FindName("CounterRadio");
            PlayingRadio = (global::Windows.UI.Xaml.Controls.RadioButton)this.FindName("PlayingRadio");
            LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("LayoutRoot");
            AdGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("AdGrid");
            AdGrid2 = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("AdGrid2");
            MainPivot = (global::Windows.UI.Xaml.Controls.Pivot)this.FindName("MainPivot");
            CounterSection = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("CounterSection");
            EasyMatchupSection = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("EasyMatchupSection");
            SynergySection = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("SynergySection");
            CounterCommentSection = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("CounterCommentSection");
            PlayingCommentSection = (global::Windows.UI.Xaml.Controls.PivotItem)this.FindName("PlayingCommentSection");
            NoPlayingComments = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("NoPlayingComments");
            NoCounterComments = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("NoCounterComments");
            NoSynergyChampions = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("NoSynergyChampions");
        }
    }
}



