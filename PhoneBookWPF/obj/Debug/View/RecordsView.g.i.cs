﻿#pragma checksum "..\..\..\View\RecordsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BD0E4CA23F479495549FCB1ED7CEB79678E8E250E9056E861CA7123A4E8D059"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.View;
using PhoneBookWPF.ViewModel;
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


namespace PhoneBookWPF.View {
    
    
    /// <summary>
    /// RecordsView
    /// </summary>
    public partial class RecordsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gRecords;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spRecordsHeaders;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bId;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bLastName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bFirstName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bFathersName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spRecordsContent;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\View\RecordsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbPhoneBookRecords;
        
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
            System.Uri resourceLocater = new System.Uri("/PhoneBookWPF;component/view/recordsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\RecordsView.xaml"
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
            this.gRecords = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.spRecordsHeaders = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.bId = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.bLastName = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.bFirstName = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.bFathersName = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.spRecordsContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.lbPhoneBookRecords = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

