﻿#pragma checksum "..\..\..\pages\salePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61D4F82E8798E7F2A9693C1B65AD221A81971BF040D1BFD0706EA29218C80233"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant.pages;
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


namespace Restaurant.pages {
    
    
    /// <summary>
    /// salePage
    /// </summary>
    public partial class salePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxSerch;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSale;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotal;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDiscount;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSubTotal;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPay;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuspend;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lwCategory;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgItems;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\pages\salePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lwData;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/pages/salepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\salePage.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\pages\salePage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tboxSerch = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\pages\salePage.xaml"
            this.tboxSerch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tboxSerch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgSale = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblDiscount = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblSubTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnPay = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\pages\salePage.xaml"
            this.btnPay.Click += new System.Windows.RoutedEventHandler(this.btnPay_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSuspend = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\pages\salePage.xaml"
            this.btnSuspend.Click += new System.Windows.RoutedEventHandler(this.btnSuspend_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\..\pages\salePage.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lwCategory = ((System.Windows.Controls.ListView)(target));
            
            #line 92 "..\..\..\pages\salePage.xaml"
            this.lwCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lwCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dtgItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 109 "..\..\..\pages\salePage.xaml"
            this.dtgItems.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dtgItems_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lwData = ((System.Windows.Controls.ListView)(target));
            
            #line 119 "..\..\..\pages\salePage.xaml"
            this.lwData.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lwData_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

