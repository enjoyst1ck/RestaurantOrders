﻿#pragma checksum "..\..\..\Views\DishAddView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "039EF5E91063BBC176C027034CE936F052D4CFA938A08B8443EFCA0D6C9A72D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using SmartDishes.Views;
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


namespace SmartDishes.Views {
    
    
    /// <summary>
    /// DishAddView
    /// </summary>
    public partial class DishAddView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishCategoryNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DishImage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\DishAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadImage;
        
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
            System.Uri resourceLocater = new System.Uri("/SmartDishes;component/views/dishaddview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DishAddView.xaml"
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
            this.DishIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DishNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DishCategoryNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DishPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DishAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DishImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.UploadImage = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Views\DishAddView.xaml"
            this.UploadImage.Click += new System.Windows.RoutedEventHandler(this.ButtonUploadImage);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 30 "..\..\..\Views\DishAddView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAddClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 32 "..\..\..\Views\DishAddView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

