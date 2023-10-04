﻿#pragma checksum "..\..\PlayView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A186C6DECF7CB5C36771946AC4357397E538CF3D53A6347BFCF59A45F9AEBA0F"
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
    /// PlayView
    /// </summary>
    public partial class PlayView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label questionCountLable;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label creatorUsername;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label rightQuestionsCounter;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn3;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\PlayView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn4;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizGameGUI;component/playview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayView.xaml"
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
            this.questionCountLable = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.creatorUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.rightQuestionsCounter = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\PlayView.xaml"
            this.btn1.Click += new System.Windows.RoutedEventHandler(this.UsersAnswer);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn2 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\PlayView.xaml"
            this.btn2.Click += new System.Windows.RoutedEventHandler(this.UsersAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn3 = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\PlayView.xaml"
            this.btn3.Click += new System.Windows.RoutedEventHandler(this.UsersAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn4 = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\PlayView.xaml"
            this.btn4.Click += new System.Windows.RoutedEventHandler(this.UsersAnswer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

