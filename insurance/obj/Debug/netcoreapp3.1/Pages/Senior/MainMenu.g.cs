﻿#pragma checksum "..\..\..\..\..\Pages\Senior\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACEF0D72632A28E83C13C22DDE2443AE45B64BCB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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
using insurance.Pages.Senior;


namespace insurance.Pages.Senior {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Scouts;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Payouts;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Requests;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/insurance;component/pages/senior/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Scouts = ((System.Windows.Controls.Image)(target));
            
            #line 16 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
            this.Scouts.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Scouts_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Payouts = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
            this.Payouts.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Payouts_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Requests = ((System.Windows.Controls.Image)(target));
            
            #line 20 "..\..\..\..\..\Pages\Senior\MainMenu.xaml"
            this.Requests.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Requests_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
