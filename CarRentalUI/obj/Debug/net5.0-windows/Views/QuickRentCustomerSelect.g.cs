﻿#pragma checksum "..\..\..\..\Views\QuickRentCustomerSelect.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6506F828626EB4BCD6B9156C7CEAAF7ACDC8FBD"
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
    /// QuickRentCustomerSelect
    /// </summary>
    public partial class QuickRentCustomerSelect : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NavigationBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListDisplay;
        
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
            System.Uri resourceLocater = new System.Uri("/CarRentalUI;component/views/quickrentcustomerselect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
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
            
            #line 32 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.StopQuickRent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.SignOutNavigation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FirstNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            this.FirstNameBox.GotFocus += new System.Windows.RoutedEventHandler(this.FirstNameBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LastNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            this.LastNameBox.GotFocus += new System.Windows.RoutedEventHandler(this.LastNameBox_OnGotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 38 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 41 "..\..\..\..\Views\QuickRentCustomerSelect.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectCustomer_onClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ListDisplay = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

