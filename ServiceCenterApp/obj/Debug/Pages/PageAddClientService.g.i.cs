﻿#pragma checksum "..\..\..\Pages\PageAddClientService.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76285FA33D62BFCDF482D7018E8E7C87C414CA58F698E9908238911679540530"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ServiceCenterApp.Pages;
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


namespace ServiceCenterApp.Pages {
    
    
    /// <summary>
    /// PageAddClientService
    /// </summary>
    public partial class PageAddClientService : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearch;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridClient;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run TxtCLient;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbxService;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDate;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtComment;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\PageAddClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreate;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceCenterApp;component/pages/pageaddclientservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageAddClientService.xaml"
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
            this.TxtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Pages\PageAddClientService.xaml"
            this.TxtSearch.SelectionChanged += new System.Windows.RoutedEventHandler(this.TxtSearch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridClient = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\Pages\PageAddClientService.xaml"
            this.GridClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtCLient = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.CmbxService = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.TxtDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtComment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Pages\PageAddClientService.xaml"
            this.BtnCreate.Click += new System.Windows.RoutedEventHandler(this.BtnCreate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
