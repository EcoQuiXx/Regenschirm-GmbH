﻿#pragma checksum "..\..\Sign-Up.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D91BED23406A3F50EA5D2C5C11A7A7E834404D4D0338094D7863526F7297143"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Love_App;
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


namespace Love_App {
    
    
    /// <summary>
    /// Sign_Up
    /// </summary>
    public partial class Sign_Up : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_username;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_email;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_password;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_question;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reg;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\Sign-Up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Sign_Up1;
        
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
            System.Uri resourceLocater = new System.Uri("/Love-App;component/sign-up.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign-Up.xaml"
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
            this.txtb_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtb_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtb_question = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_reg = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\Sign-Up.xaml"
            this.btn_reg.Click += new System.Windows.RoutedEventHandler(this.ClickReg);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\Sign-Up.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.LoginClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sign_Up1 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

