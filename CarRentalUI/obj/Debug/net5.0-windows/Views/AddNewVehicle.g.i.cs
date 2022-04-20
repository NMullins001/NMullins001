﻿#pragma checksum "..\..\..\..\Views\AddNewVehicle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94596A21CF7E2B0A7AB642F275B5889FEF4D5D3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarRentalUI.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CarRentalUI.Views {
    
    
    /// <summary>
    /// AddNewVehicle
    /// </summary>
    public partial class AddNewVehicle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NavigationBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VinNumberBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ManufacturerBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ColorBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VehicleTypeBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConditionBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MilesBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\AddNewVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PricePerDay;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarRentalUI;component/views/addnewvehicle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddNewVehicle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CustomerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NavigationBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 35 "..\..\..\..\Views\AddNewVehicle.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GoToVehicleManagement);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\..\..\Views\AddNewVehicle.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.GoToEmployeeSplashPage);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\..\Views\AddNewVehicle.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.SignOut);
            
            #line default
            #line hidden
            return;
            case 6:
            this.VinNumberBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.VinNumberBox.GotFocus += new System.Windows.RoutedEventHandler(this.VinNumberBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ManufacturerBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.ManufacturerBox.GotFocus += new System.Windows.RoutedEventHandler(this.ManufacturerBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ModelBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.ModelBox.GotFocus += new System.Windows.RoutedEventHandler(this.ModelBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ColorBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.ColorBox.GotFocus += new System.Windows.RoutedEventHandler(this.ColorBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.VehicleTypeBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.VehicleTypeBox.GotFocus += new System.Windows.RoutedEventHandler(this.VehicleTypeBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ConditionBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.ConditionBox.GotFocus += new System.Windows.RoutedEventHandler(this.ConditionBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            this.YearBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.YearBox.GotFocus += new System.Windows.RoutedEventHandler(this.YearBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 13:
            this.MilesBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.MilesBox.GotFocus += new System.Windows.RoutedEventHandler(this.MilesBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 14:
            this.PricePerDay = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\Views\AddNewVehicle.xaml"
            this.PricePerDay.GotFocus += new System.Windows.RoutedEventHandler(this.PricePerDay_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 50 "..\..\..\..\Views\AddNewVehicle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddVehicle);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

