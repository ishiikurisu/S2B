﻿#pragma checksum "c:\Users\cristiano.alves\Documents\Visual Studio 2015\Projects\Aula5\ExemploMVVM\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "413EF5F09389F4722149E17306C629F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExemploMVVM
{
    partial class MainPage : 
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
                    this.txtUsuario = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.lblUsuario = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.lblSenha = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.psbSenha = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5:
                {
                    this.lblMensagem = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.lblQualIdade = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtIdade = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtIdade).TextChanged += this.txtIdade_TextChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.sliIdade = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 19 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sliIdade).ValueChanged += this.sliIdade_ValueChanged;
                    #line default
                }
                break;
            case 9:
                {
                    this.chkAdmin = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 10:
                {
                    this.btnLogar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogar).Click += this.btnLogar_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.radBSB = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 12:
                {
                    this.radSP = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 13:
                {
                    this.lblFilial = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

