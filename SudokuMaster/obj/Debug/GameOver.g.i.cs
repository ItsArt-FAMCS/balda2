﻿#pragma checksum "C:\Users\Nath\Desktop\sudokumaster_silverlight\SudokuMaster\GameOver.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A8363C599D86042257B614499106A9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SudokuMaster {
    
    
    public partial class GameOver : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textBlockHeading;
        
        internal System.Windows.Controls.TextBlock textBlockTime;
        
        internal System.Windows.Controls.TextBlock textBlockPlacement;
        
        internal System.Windows.Controls.TextBox playerName;
        
        internal System.Windows.Controls.Button ConfirmButton;
        
        internal System.Windows.Media.Animation.Storyboard fadeInAnimation;
        
        internal System.Windows.Media.Animation.Storyboard fadeOutAnimation;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SudokuMaster;component/GameOver.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textBlockHeading = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockHeading")));
            this.textBlockTime = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockTime")));
            this.textBlockPlacement = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockPlacement")));
            this.playerName = ((System.Windows.Controls.TextBox)(this.FindName("playerName")));
            this.ConfirmButton = ((System.Windows.Controls.Button)(this.FindName("ConfirmButton")));
            this.fadeInAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("fadeInAnimation")));
            this.fadeOutAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("fadeOutAnimation")));
        }
    }
}

