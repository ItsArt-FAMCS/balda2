﻿#pragma checksum "C:\Users\Nath\Desktop\sudokumaster_silverlight\SudokuMaster\NumberSelection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "01723513B51160AE7F862D264DB0B0BF"
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
    
    
    public partial class NumberSelection : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid keyboardGrid;
        
        internal System.Windows.Controls.Grid grid1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/balda;component/NumberSelection.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.keyboardGrid = ((System.Windows.Controls.Grid)(this.FindName("keyboardGrid")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.fadeInAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("fadeInAnimation")));
            this.fadeOutAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("fadeOutAnimation")));
        }
    }
}

