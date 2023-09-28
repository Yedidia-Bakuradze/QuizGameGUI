﻿#pragma checksum "..\..\SignupView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BA0B67E60942CB750D92B96B4DA7BB82C37E0DB7CE4B2C7BC5EE74266E52EDC"
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
    /// SignupView
    /// </summary>
    public partial class SignupView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameField;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameField;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordField;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel loginRediraction;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SignupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizGameGUI;component/signupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SignupView.xaml"
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
            this.nameField = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\SignupView.xaml"
            this.nameField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.usernameField = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\SignupView.xaml"
            this.usernameField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordField = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\SignupView.xaml"
            this.passwordField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\SignupView.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.SubmitSignup);
            
            #line default
            #line hidden
            return;
            case 5:
            this.loginRediraction = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.errorMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 42 "..\..\SignupView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Login);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

