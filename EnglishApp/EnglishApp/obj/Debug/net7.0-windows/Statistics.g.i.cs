﻿#pragma checksum "..\..\..\Statistics.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C54588BD009614DF349450B40654B79B21E5D64"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EnglishApp;
using System;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EnglishApp {
    
    
    /// <summary>
    /// Statistics
    /// </summary>
    public partial class Statistics : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ch_L_B;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LearnE;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetAll;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DisAds;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EnglishApp;component/statistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Statistics.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 48 "..\..\..\Statistics.xaml"
            ((System.Windows.Controls.ListView)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.ListView_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ch_L_B = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Statistics.xaml"
            this.Ch_L_B.Click += new System.Windows.RoutedEventHandler(this.Ch_L_B_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LearnE = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Statistics.xaml"
            this.LearnE.Click += new System.Windows.RoutedEventHandler(this.LearnE_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResetAll = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Statistics.xaml"
            this.ResetAll.Click += new System.Windows.RoutedEventHandler(this.ResetAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DisAds = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Statistics.xaml"
            this.DisAds.Click += new System.Windows.RoutedEventHandler(this.DisAds_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
