#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb20da973136d2ffddd78eeda62bdcd4186c4f5c"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-config")]
    public partial class AddTblConfig : Bssr.Pages.AddTblConfigComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblConfig>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblConfig>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                   tblconfig

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                         tblconfig != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblConfig>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblConfig>(this, 
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
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
                    __builder3.AddAttribute(24, "Text", "Opis");
                    __builder3.AddAttribute(25, "Component", "Opis");
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
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Opis");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                                 tblconfig.Opis

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.Opis = __value, tblconfig.Opis))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblconfig.Opis));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Opis");
                    __builder3.AddAttribute(42, "Text", "Opis is required");
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
                    __builder3.AddAttribute(55, "Text", "Ime");
                    __builder3.AddAttribute(56, "Component", "Ime");
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
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Ime");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                                 tblconfig.Ime

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.Ime = __value, tblconfig.Ime))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblconfig.Ime));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Ime");
                    __builder3.AddAttribute(73, "Text", "Ime is required");
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
                    __builder3.AddAttribute(86, "Text", "Vrednost");
                    __builder3.AddAttribute(87, "Component", "Vrednost");
                    __builder3.AddAttribute(88, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-9");
                    __builder3.AddMarkupContent(93, "\n                ");
                    __Blazor.Bssr.Pages.AddTblConfig.TypeInference.CreateRadzenNumeric_0(__builder3, 94, 95, "width: 100%", 96, "Vrednost", 97, 
#line 44 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                  tblconfig.Vrednost

#line default
#line hidden
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.Vrednost = __value, tblconfig.Vrednost)), 99, () => tblconfig.Vrednost);
                    __builder3.AddMarkupContent(100, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(105, "class", "row");
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "col-md-3");
                    __builder3.AddMarkupContent(109, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(110);
                    __builder3.AddAttribute(111, "Text", "Nivo Na Administracija");
                    __builder3.AddAttribute(112, "Component", "NivoNaAdministracija");
                    __builder3.AddAttribute(113, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "col-md-9");
                    __builder3.AddMarkupContent(118, "\n                ");
                    __Blazor.Bssr.Pages.AddTblConfig.TypeInference.CreateRadzenNumeric_1(__builder3, 119, 120, "width: 100%", 121, "NivoNaAdministracija", 122, 
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                  tblconfig.NivoNaAdministracija

#line default
#line hidden
                    , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.NivoNaAdministracija = __value, tblconfig.NivoNaAdministracija)), 124, () => tblconfig.NivoNaAdministracija);
                    __builder3.AddMarkupContent(125, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\n            ");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(130, "class", "row");
                    __builder3.AddMarkupContent(131, "\n              ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "class", "col-md-3");
                    __builder3.AddMarkupContent(134, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(135);
                    __builder3.AddAttribute(136, "Text", "Range");
                    __builder3.AddAttribute(137, "Component", "Range");
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(140, "\n              ");
                    __builder3.OpenElement(141, "div");
                    __builder3.AddAttribute(142, "class", "col-md-9");
                    __builder3.AddMarkupContent(143, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(144);
                    __builder3.AddAttribute(145, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 64 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(146, "style", "width: 100%");
                    __builder3.AddAttribute(147, "Name", "Range");
                    __builder3.AddAttribute(148, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 64 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                 tblconfig.Range

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(149, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.Range = __value, tblconfig.Range))));
                    __builder3.AddAttribute(150, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblconfig.Range));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(152, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(153, "\n            ");
                    __builder3.OpenElement(154, "div");
                    __builder3.AddAttribute(155, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(156, "class", "row");
                    __builder3.AddMarkupContent(157, "\n              ");
                    __builder3.OpenElement(158, "div");
                    __builder3.AddAttribute(159, "class", "col-md-3");
                    __builder3.AddMarkupContent(160, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(161);
                    __builder3.AddAttribute(162, "Text", "Ime Na Modul");
                    __builder3.AddAttribute(163, "Component", "ImeNaModul");
                    __builder3.AddAttribute(164, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(165, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\n              ");
                    __builder3.OpenElement(167, "div");
                    __builder3.AddAttribute(168, "class", "col-md-9");
                    __builder3.AddMarkupContent(169, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(170);
                    __builder3.AddAttribute(171, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 74 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(172, "style", "width: 100%");
                    __builder3.AddAttribute(173, "Name", "ImeNaModul");
                    __builder3.AddAttribute(174, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 74 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                 tblconfig.ImeNaModul

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(175, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.ImeNaModul = __value, tblconfig.ImeNaModul))));
                    __builder3.AddAttribute(176, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblconfig.ImeNaModul));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(178, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(179, "\n            ");
                    __builder3.OpenElement(180, "div");
                    __builder3.AddAttribute(181, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(182, "class", "row");
                    __builder3.AddMarkupContent(183, "\n              ");
                    __builder3.OpenElement(184, "div");
                    __builder3.AddAttribute(185, "class", "col-md-3");
                    __builder3.AddMarkupContent(186, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(187);
                    __builder3.AddAttribute(188, "Text", "Firma Id");
                    __builder3.AddAttribute(189, "Component", "FirmaID");
                    __builder3.AddAttribute(190, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(191, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(192, "\n              ");
                    __builder3.OpenElement(193, "div");
                    __builder3.AddAttribute(194, "class", "col-md-9");
                    __builder3.AddMarkupContent(195, "\n                ");
                    __Blazor.Bssr.Pages.AddTblConfig.TypeInference.CreateRadzenNumeric_2(__builder3, 196, 197, "display: block; width: 100%", 198, "FirmaID", 199, 
#line 84 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                  tblconfig.FirmaID

#line default
#line hidden
                    , 200, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblconfig.FirmaID = __value, tblconfig.FirmaID)), 201, () => tblconfig.FirmaID);
                    __builder3.AddMarkupContent(202, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(203);
                    __builder3.AddAttribute(204, "Component", "FirmaID");
                    __builder3.AddAttribute(205, "Text", "FirmaID is required");
                    __builder3.AddAttribute(206, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(207, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(208, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(209, "\n            ");
                    __builder3.OpenElement(210, "div");
                    __builder3.AddAttribute(211, "class", "row");
                    __builder3.AddMarkupContent(212, "\n              ");
                    __builder3.OpenElement(213, "div");
                    __builder3.AddAttribute(214, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(215, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(216);
                    __builder3.AddAttribute(217, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 92 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(218, "Icon", "save");
                    __builder3.AddAttribute(219, "Text", "Save");
                    __builder3.AddAttribute(220, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 92 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(221, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(222);
                    __builder3.AddAttribute(223, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 94 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(224, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(225, "Text", "Cancel");
                    __builder3.AddAttribute(226, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 94 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblConfig.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(227, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(228, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(229, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(230, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(231, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(232, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Bssr.Pages.AddTblConfig
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
        public static void CreateRadzenNumeric_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
