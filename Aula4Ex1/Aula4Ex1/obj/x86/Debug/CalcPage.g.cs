﻿#pragma checksum "c:\users\cristiano.alves\documents\visual studio 2015\Projects\Aula4Ex1\Aula4Ex1\CalcPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31AF81433BEE2F6E0C3C232FEC979D0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aula4Ex1
{
    partial class CalcPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.lblNum1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.txtNum1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.lblNum2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.txtNum2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.btnSomar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\CalcPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSomar).Click += this.btnSomar_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnSubtrair = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\CalcPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubtrair).Click += this.btnSubtrair_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.btnDividir = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\CalcPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDividir).Click += this.btnDividir_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.lblMostrarResultado = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.lblResultado = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.btnRetornar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\CalcPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRetornar).Click += this.btnRetornar_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

