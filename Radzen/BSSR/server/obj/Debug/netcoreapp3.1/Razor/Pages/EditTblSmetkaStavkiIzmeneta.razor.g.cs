#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b32b7d9eb7b59cdc7030655b1d726081e5d6b76"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-smetka-stavki-izmeneta/{ID}")]
    public partial class EditTblSmetkaStavkiIzmeneta : Bssr.Pages.EditTblSmetkaStavkiIzmenetaComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                      tblsmetkastavkiizmenetum

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                                                           tblsmetkastavkiizmenetum != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum>(this, 
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
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
                    __builder3.AddAttribute(24, "Text", "Tbl Smetka Id");
                    __builder3.AddAttribute(25, "Component", "tblSmetkaID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "display: block; width: 100%", 34, "TblSmetkaID", 35, 
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                  tblsmetkastavkiizmenetum.tblSmetkaID

#line default
#line hidden
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.tblSmetkaID = __value, tblsmetkastavkiizmenetum.tblSmetkaID)), 37, () => tblsmetkastavkiizmenetum.tblSmetkaID);
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "TblSmetkaID");
                    __builder3.AddAttribute(41, "Text", "tblSmetkaID is required");
                    __builder3.AddAttribute(42, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "Text", "Tbl Nalog Id");
                    __builder3.AddAttribute(55, "Component", "tblNalogID");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_1(__builder3, 62, 63, "display: block; width: 100%", 64, "TblNalogID", 65, 
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                  tblsmetkastavkiizmenetum.tblNalogID

#line default
#line hidden
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.tblNalogID = __value, tblsmetkastavkiizmenetum.tblNalogID)), 67, () => tblsmetkastavkiizmenetum.tblNalogID);
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "TblNalogID");
                    __builder3.AddAttribute(71, "Text", "tblNalogID is required");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(78, "class", "row");
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-md-3");
                    __builder3.AddMarkupContent(82, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(83);
                    __builder3.AddAttribute(84, "Text", "Status");
                    __builder3.AddAttribute(85, "Component", "Status");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-9");
                    __builder3.AddMarkupContent(91, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_2(__builder3, 92, 93, "width: 100%", 94, "Status", 95, 
#line 44 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                  tblsmetkastavkiizmenetum.Status

#line default
#line hidden
                    , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.Status = __value, tblsmetkastavkiizmenetum.Status)), 97, () => tblsmetkastavkiizmenetum.Status);
                    __builder3.AddMarkupContent(98, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-md-3");
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(108);
                    __builder3.AddAttribute(109, "Text", "Kolicina");
                    __builder3.AddAttribute(110, "Component", "Kolicina");
                    __builder3.AddAttribute(111, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\n              ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col-md-9");
                    __builder3.AddMarkupContent(116, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_3(__builder3, 117, 118, "display: block; width: 100%", 119, "Kolicina", 120, 
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                  tblsmetkastavkiizmenetum.Kolicina

#line default
#line hidden
                    , 121, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.Kolicina = __value, tblsmetkastavkiizmenetum.Kolicina)), 122, () => tblsmetkastavkiizmenetum.Kolicina);
                    __builder3.AddMarkupContent(123, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(124);
                    __builder3.AddAttribute(125, "Component", "Kolicina");
                    __builder3.AddAttribute(126, "Text", "Kolicina is required");
                    __builder3.AddAttribute(127, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(128, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n            ");
                    __builder3.OpenElement(131, "div");
                    __builder3.AddAttribute(132, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(133, "class", "row");
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-3");
                    __builder3.AddMarkupContent(137, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(138);
                    __builder3.AddAttribute(139, "Text", "Cena");
                    __builder3.AddAttribute(140, "Component", "Cena");
                    __builder3.AddAttribute(141, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "class", "col-md-9");
                    __builder3.AddMarkupContent(146, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_4(__builder3, 147, 148, "display: block; width: 100%", 149, "Cena", 150, 
#line 66 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                  tblsmetkastavkiizmenetum.Cena

#line default
#line hidden
                    , 151, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.Cena = __value, tblsmetkastavkiizmenetum.Cena)), 152, () => tblsmetkastavkiizmenetum.Cena);
                    __builder3.AddMarkupContent(153, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(154);
                    __builder3.AddAttribute(155, "Component", "Cena");
                    __builder3.AddAttribute(156, "Text", "Cena is required");
                    __builder3.AddAttribute(157, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(158, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(160, "\n            ");
                    __builder3.OpenElement(161, "div");
                    __builder3.AddAttribute(162, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(163, "class", "row");
                    __builder3.AddMarkupContent(164, "\n              ");
                    __builder3.OpenElement(165, "div");
                    __builder3.AddAttribute(166, "class", "col-md-3");
                    __builder3.AddMarkupContent(167, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(168);
                    __builder3.AddAttribute(169, "Text", "Datum Na Izmena");
                    __builder3.AddAttribute(170, "Component", "DatumNaIzmena");
                    __builder3.AddAttribute(171, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\n              ");
                    __builder3.OpenElement(174, "div");
                    __builder3.AddAttribute(175, "class", "col-md-9");
                    __builder3.AddMarkupContent(176, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenDatePicker_5(__builder3, 177, 178, "MM/dd/yyyy", 179, "width: 100%", 180, "DatumNaIzmena", 181, 
#line 78 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                             tblsmetkastavkiizmenetum.DatumNaIzmena

#line default
#line hidden
                    , 182, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.DatumNaIzmena = __value, tblsmetkastavkiizmenetum.DatumNaIzmena)), 183, () => tblsmetkastavkiizmenetum.DatumNaIzmena);
                    __builder3.AddMarkupContent(184, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(185, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(186, "\n            ");
                    __builder3.OpenElement(187, "div");
                    __builder3.AddAttribute(188, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(189, "class", "row");
                    __builder3.AddMarkupContent(190, "\n              ");
                    __builder3.OpenElement(191, "div");
                    __builder3.AddAttribute(192, "class", "col-md-3");
                    __builder3.AddMarkupContent(193, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(194);
                    __builder3.AddAttribute(195, "Text", "Tbl Smetka Izmeneta Id");
                    __builder3.AddAttribute(196, "Component", "tblSmetkaIzmenetaID");
                    __builder3.AddAttribute(197, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(198, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(199, "\n              ");
                    __builder3.OpenElement(200, "div");
                    __builder3.AddAttribute(201, "class", "col-md-9");
                    __builder3.AddMarkupContent(202, "\n                ");
                    __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta.TypeInference.CreateRadzenNumeric_6(__builder3, 203, 204, "width: 100%", 205, "TblSmetkaIzmenetaID", 206, 
#line 88 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                  tblsmetkastavkiizmenetum.tblSmetkaIzmenetaID

#line default
#line hidden
                    , 207, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblsmetkastavkiizmenetum.tblSmetkaIzmenetaID = __value, tblsmetkastavkiizmenetum.tblSmetkaIzmenetaID)), 208, () => tblsmetkastavkiizmenetum.tblSmetkaIzmenetaID);
                    __builder3.AddMarkupContent(209, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(210, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(211, "\n            ");
                    __builder3.OpenElement(212, "div");
                    __builder3.AddAttribute(213, "class", "row");
                    __builder3.AddMarkupContent(214, "\n              ");
                    __builder3.OpenElement(215, "div");
                    __builder3.AddAttribute(216, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(217, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(218);
                    __builder3.AddAttribute(219, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 94 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(220, "Icon", "save");
                    __builder3.AddAttribute(221, "Text", "Save");
                    __builder3.AddAttribute(222, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 94 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(223, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(224);
                    __builder3.AddAttribute(225, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 96 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(226, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(227, "Text", "Cancel");
                    __builder3.AddAttribute(228, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 96 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\EditTblSmetkaStavkiIzmeneta.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(229, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(230, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(231, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(232, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(233, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(234, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Bssr.Pages.EditTblSmetkaStavkiIzmeneta
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
        public static void CreateRadzenNumeric_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
