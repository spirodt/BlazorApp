#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc285290b256e29a575055afad9748b00012bf8f"
// <auto-generated/>
#pragma warning disable 1591
namespace Bssr.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\_Imports.razor"
using Bssr.Shared;

#line default
#line hidden
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-presmetkovni-edinici")]
    public partial class AddTblPresmetkovniEdinici : Bssr.Pages.AddTblPresmetkovniEdiniciComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblPresmetkovniEdinici>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblPresmetkovniEdinici>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                   tblpresmetkovniedinici

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                      tblpresmetkovniedinici != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblPresmetkovniEdinici>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblPresmetkovniEdinici>(this, 
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                                                                                                 Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Sifra");
                    __builder3.AddAttribute(25, "Component", "Sifra");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                          20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Sifra");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                                 tblpresmetkovniedinici.Sifra

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpresmetkovniedinici.Sifra = __value, tblpresmetkovniedinici.Sifra))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblpresmetkovniedinici.Sifra));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Sifra");
                    __builder3.AddAttribute(42, "Text", "Sifra is required");
                    __builder3.AddAttribute(43, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Naziv");
                    __builder3.AddAttribute(56, "Component", "Naziv");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Naziv");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                                 tblpresmetkovniedinici.Naziv

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpresmetkovniedinici.Naziv = __value, tblpresmetkovniedinici.Naziv))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblpresmetkovniedinici.Naziv));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Naziv");
                    __builder3.AddAttribute(73, "Text", "Naziv is required");
                    __builder3.AddAttribute(74, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "col-md-3");
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(85);
                    __builder3.AddAttribute(86, "Text", "Firma Id");
                    __builder3.AddAttribute(87, "Component", "FirmaID");
                    __builder3.AddAttribute(88, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-9");
                    __builder3.AddMarkupContent(93, "\n                ");
                    __Blazor.Bssr.Pages.AddTblPresmetkovniEdinici.TypeInference.CreateRadzenNumeric_0(__builder3, 94, 95, "display: block; width: 100%", 96, "FirmaID", 97, 
#line 44 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                  tblpresmetkovniedinici.FirmaID

#line default
#line hidden
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpresmetkovniedinici.FirmaID = __value, tblpresmetkovniedinici.FirmaID)), 99, () => tblpresmetkovniedinici.FirmaID);
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(101);
                    __builder3.AddAttribute(102, "Component", "FirmaID");
                    __builder3.AddAttribute(103, "Text", "FirmaID is required");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(110, "class", "row");
                    __builder3.AddMarkupContent(111, "\n              ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "col-md-3");
                    __builder3.AddMarkupContent(114, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(115);
                    __builder3.AddAttribute(116, "Text", "Zabeleska");
                    __builder3.AddAttribute(117, "Component", "Zabeleska");
                    __builder3.AddAttribute(118, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col-md-9");
                    __builder3.AddMarkupContent(123, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(124);
                    __builder3.AddAttribute(125, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                          100

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(126, "style", "width: 100%");
                    __builder3.AddAttribute(127, "Name", "Zabeleska");
                    __builder3.AddAttribute(128, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                  tblpresmetkovniedinici.Zabeleska

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(129, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpresmetkovniedinici.Zabeleska = __value, tblpresmetkovniedinici.Zabeleska))));
                    __builder3.AddAttribute(130, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblpresmetkovniedinici.Zabeleska));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(136, "class", "row");
                    __builder3.AddMarkupContent(137, "\n              ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "class", "col-md-3");
                    __builder3.AddMarkupContent(140, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(141);
                    __builder3.AddAttribute(142, "Text", "Status");
                    __builder3.AddAttribute(143, "Component", "Status");
                    __builder3.AddAttribute(144, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col-md-9");
                    __builder3.AddMarkupContent(149, "\n                ");
                    __Blazor.Bssr.Pages.AddTblPresmetkovniEdinici.TypeInference.CreateRadzenNumeric_1(__builder3, 150, 151, "width: 100%", 152, "Status", 153, 
#line 66 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                  tblpresmetkovniedinici.Status

#line default
#line hidden
                    , 154, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpresmetkovniedinici.Status = __value, tblpresmetkovniedinici.Status)), 155, () => tblpresmetkovniedinici.Status);
                    __builder3.AddMarkupContent(156, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\n            ");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "class", "row");
                    __builder3.AddMarkupContent(161, "\n              ");
                    __builder3.OpenElement(162, "div");
                    __builder3.AddAttribute(163, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(164, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(165);
                    __builder3.AddAttribute(166, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 72 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(167, "Icon", "save");
                    __builder3.AddAttribute(168, "Text", "Save");
                    __builder3.AddAttribute(169, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 72 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(171);
                    __builder3.AddAttribute(172, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 74 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(173, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(174, "Text", "Cancel");
                    __builder3.AddAttribute(175, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 74 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblPresmetkovniEdinici.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(177, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(178, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(179, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Bssr.Pages.AddTblPresmetkovniEdinici
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
