﻿#pragma checksum "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "073DDEB61E794421A951D2D294A34CE97680A944F81F4561AA6751AEBEDC2CFA"
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
    /// QuestionEditorView
    /// </summary>
    public partial class QuestionEditorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label questionCounterField;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox theQuestionFiled;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quizTheme;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fAns1Field;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fAns2Field;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fAns3Field;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tAnsField;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quizDoneButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextQuestionButton;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizGameGUI;component/views/homeview%20views/questioneditorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
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
            this.questionCounterField = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.theQuestionFiled = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.theQuestionFiled.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.quizTheme = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.quizTheme.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.fAns1Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.fAns1Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fAns2Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.fAns2Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.fAns3Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.fAns3Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tAnsField = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.tAnsField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextboxValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.quizDoneButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.quizDoneButton.Click += new System.Windows.RoutedEventHandler(this.QuizDone);
            
            #line default
            #line hidden
            return;
            case 9:
            this.nextQuestionButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\Views\HomeView Views\QuestionEditorView.xaml"
            this.nextQuestionButton.Click += new System.Windows.RoutedEventHandler(this.AddQuestion);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
