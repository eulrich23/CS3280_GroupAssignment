﻿#pragma checksum "..\..\..\Search\wndSearch.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1295949817C50EB27352D5FE43AE5EF44A11AFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Group_Project_Assignment;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Group_Project_Assignment {
    
    
    /// <summary>
    /// wndSearch
    /// </summary>
    public partial class wndSearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Group_Project_Assignment.wndSearch wndSearchWindow;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgrdInvoiceSearch;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbInvoiceNumber;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbInvoiceDate;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTotalCharge;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Search\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearSelection;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/8GroupAssignment;component/search/wndsearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Search\wndSearch.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.wndSearchWindow = ((Group_Project_Assignment.wndSearch)(target));
            
            #line 8 "..\..\..\Search\wndSearch.xaml"
            this.wndSearchWindow.Closed += new System.EventHandler(this.wndSearchWindow_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtgrdInvoiceSearch = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnSelect = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Search\wndSearch.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.btnSelect_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Search\wndSearch.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbInvoiceNumber = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\Search\wndSearch.xaml"
            this.cmbInvoiceNumber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbInvoiceNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbInvoiceDate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\Search\wndSearch.xaml"
            this.cmbInvoiceDate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbInvoiceDate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbTotalCharge = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Search\wndSearch.xaml"
            this.cmbTotalCharge.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbTotalCharge_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClearSelection = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Search\wndSearch.xaml"
            this.btnClearSelection.Click += new System.Windows.RoutedEventHandler(this.btnClearSelection_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

