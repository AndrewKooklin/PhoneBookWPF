﻿#pragma checksum "..\..\..\View\ActionDeleteUserView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99C440137445EE90F6A278CD19BCF5EF135DC1E19C524B81B1CE2C255126E4F5"
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
using PhoneBookWPF.Model;
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
    /// ActionDeleteUserView
    /// </summary>
    public partial class ActionDeleteUserView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gUser;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUserId;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbErrorEmail;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbResult;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\View\ActionDeleteUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDeleteUser;
        
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
            System.Uri resourceLocater = new System.Uri("/PhoneBookWPF;component/view/actiondeleteuserview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ActionDeleteUserView.xaml"
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
            this.gUser = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tbUserId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbErrorEmail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.bDeleteUser = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

