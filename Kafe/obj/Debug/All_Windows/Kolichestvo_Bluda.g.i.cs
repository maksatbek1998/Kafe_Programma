﻿#pragma checksum "..\..\..\All_Windows\Kolichestvo_Bluda.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C279E7F64DF3806442257B65CE3F2C5758C636C54B0BDACFD45925B8D666A623"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Kafe.All_Windows;
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


namespace Kafe.All_Windows {
    
    
    /// <summary>
    /// Kolichestvo_Bluda
    /// </summary>
    public partial class Kolichestvo_Bluda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text_Kolichestvo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plus_Button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minus_Button;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plus_Button_Copy1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minus_Button_Copy1;
        
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
            System.Uri resourceLocater = new System.Uri("/Kafe;component/all_windows/kolichestvo_bluda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
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
            this.Text_Kolichestvo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 21 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Plus_Button = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
            this.Plus_Button.Click += new System.Windows.RoutedEventHandler(this.Plus_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Minus_Button = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
            this.Minus_Button.Click += new System.Windows.RoutedEventHandler(this.Plus_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Plus_Button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
            this.Plus_Button_Copy1.Click += new System.Windows.RoutedEventHandler(this.Plus_Button_Copy);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Minus_Button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\All_Windows\Kolichestvo_Bluda.xaml"
            this.Minus_Button_Copy1.Click += new System.Windows.RoutedEventHandler(this.Plus_Button_Copy);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

