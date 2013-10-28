﻿#pragma checksum "C:\Users\Nath\Desktop\sudokumaster_silverlight\SudokuMaster\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3A3034F98E80D244419C678428E26EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using SudokuMaster;
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid BoardGrid;
        
        internal System.Windows.Controls.Grid Statistics;
        
        internal System.Windows.Controls.Image MovesImage;
        
        internal System.Windows.Controls.TextBlock Moves;
        
        internal System.Windows.Controls.Image EmptyImage;
        
        internal System.Windows.Controls.TextBlock Empty;
        
        internal System.Windows.Controls.Image GameTimeImage;
        
        internal System.Windows.Controls.TextBlock GameTime;
        
        internal SudokuMaster.NumberSelection numberSelection;
        
        internal SudokuMaster.WaitNote waitIndicator;
        
        internal System.Windows.Controls.TextBox playerTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/balda;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.BoardGrid = ((System.Windows.Controls.Grid)(this.FindName("BoardGrid")));
            this.Statistics = ((System.Windows.Controls.Grid)(this.FindName("Statistics")));
            this.MovesImage = ((System.Windows.Controls.Image)(this.FindName("MovesImage")));
            this.Moves = ((System.Windows.Controls.TextBlock)(this.FindName("Moves")));
            this.EmptyImage = ((System.Windows.Controls.Image)(this.FindName("EmptyImage")));
            this.Empty = ((System.Windows.Controls.TextBlock)(this.FindName("Empty")));
            this.GameTimeImage = ((System.Windows.Controls.Image)(this.FindName("GameTimeImage")));
            this.GameTime = ((System.Windows.Controls.TextBlock)(this.FindName("GameTime")));
            this.numberSelection = ((SudokuMaster.NumberSelection)(this.FindName("numberSelection")));
            this.waitIndicator = ((SudokuMaster.WaitNote)(this.FindName("waitIndicator")));
            this.playerTextBox = ((System.Windows.Controls.TextBox)(this.FindName("playerTextBox")));
        }
    }
}
