﻿#pragma checksum "..\..\..\Properties\EditRecord.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB20A960FE66A0A26B39CBA18D5476AD791E8FB819A23F87751674769C122994"
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
using kapustinRPMBD.Properties;


namespace kapustinRPMBD.Properties {
    
    
    /// <summary>
    /// EditRecord
    /// </summary>
    public partial class EditRecord : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FlightNumTB;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DestinationTB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DepartureTimeTB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArrivalTimeTB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AvailableSeatsCountTB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AircraftTypeTB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CapacityTB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRecordTB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Properties\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelTB;
        
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
            System.Uri resourceLocater = new System.Uri("/kapustinRPMBD;component/properties/editrecord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Properties\EditRecord.xaml"
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
            this.FlightNumTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DestinationTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DepartureTimeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ArrivalTimeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AvailableSeatsCountTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AircraftTypeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CapacityTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AddRecordTB = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Properties\EditRecord.xaml"
            this.AddRecordTB.Click += new System.Windows.RoutedEventHandler(this.AddRecordTB_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelTB = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

