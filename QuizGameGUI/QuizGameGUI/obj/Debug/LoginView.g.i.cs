﻿#pragma checksum "..\..\LoginView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51B8DB634DE868AAF56E9500AB67510915B67839D80937B12FAF1770D46D06B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuizGameGUI;
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


namespace QuizGameGUI {
    
    
    /// <summary>
    /// LoginView
    /// </summary>
    public partial class LoginView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameField;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordField;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel passwordResetRediraction;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel signupRediraction;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizGameGUI;component/loginview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginView.xaml"
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
            this.usernameField = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\LoginView.xaml"
            this.usernameField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.passwordField = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\LoginView.xaml"
            this.passwordField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\LoginView.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.UserLogin);
            
            #line default
            #line hidden
            return;
            case 4:
            this.errorMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.passwordResetRediraction = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 43 "..\..\LoginView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PasswordResetButton);
            
            #line default
            #line hidden
            return;
            case 7:
            this.signupRediraction = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 49 "..\..\LoginView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignupButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

