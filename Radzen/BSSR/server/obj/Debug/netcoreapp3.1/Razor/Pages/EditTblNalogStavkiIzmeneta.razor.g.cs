#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b273e81ca86918d5287eaeefb97a0602b0e6c2a"
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
#line 1 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\_Imports.razor"
using Bssr.Shared;

#line default
#line hidden
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-nalog-stavki-izmeneta/{ID}")]
    public partial class EditTblNalogStavkiIzmeneta : Bssr.Pages.EditTblNalogStavkiIzmenetaComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                                     tblnalogstavkiizmenetum

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                                                                         tblnalogstavkiizmenetum != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum>(this, 
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
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
                    __builder3.AddAttribute(24, "Text", "Tbl Nalog Izmeneta Id");
                    __builder3.AddAttribute(25, "Component", "tblNalogIzmenetaID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "display: block; width: 100%", 34, "TblNalogIzmenetaID", 35, 
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                                  tblnalogstavkiizmenetum.tblNalogIzmenetaID

#line default
#line hidden
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnalogstavkiizmenetum.tblNalogIzmenetaID = __value, tblnalogstavkiizmenetum.tblNalogIzmenetaID)), 37, () => tblnalogstavkiizmenetum.tblNalogIzmenetaID);
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "TblNalogIzmenetaID");
                    __builder3.AddAttribute(41, "Text", "tblNalogIzmenetaID is required");
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
                    __builder3.AddAttribute(54, "Text", "Tbl Nomativ Id");
                    __builder3.AddAttribute(55, "Component", "tblNomativID");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta.TypeInference.CreateRadzenNumeric_1(__builder3, 62, 63, "width: 100%", 64, "TblNomativID", 65, 
#line 33 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                  tblnalogstavkiizmenetum.tblNomativID

#line default
#line hidden
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnalogstavkiizmenetum.tblNomativID = __value, tblnalogstavkiizmenetum.tblNomativID)), 67, () => tblnalogstavkiizmenetum.tblNomativID);
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.AddMarkupContent(74, "\n              ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "col-md-3");
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(78);
                    __builder3.AddAttribute(79, "Text", "Tbl Artikal Id");
                    __builder3.AddAttribute(80, "Component", "tblArtikalID");
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __builder3.AddMarkupContent(86, "\n                ");
                    __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta.TypeInference.CreateRadzenNumeric_2(__builder3, 87, 88, "width: 100%", 89, "TblArtikalID", 90, 
#line 43 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                  tblnalogstavkiizmenetum.tblArtikalID

#line default
#line hidden
                    , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnalogstavkiizmenetum.tblArtikalID = __value, tblnalogstavkiizmenetum.tblArtikalID)), 92, () => tblnalogstavkiizmenetum.tblArtikalID);
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(98, "class", "row");
                    __builder3.AddMarkupContent(99, "\n              ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col-md-3");
                    __builder3.AddMarkupContent(102, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
                    __builder3.AddAttribute(104, "Text", "Kolicina");
                    __builder3.AddAttribute(105, "Component", "Kolicina");
                    __builder3.AddAttribute(106, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n              ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-9");
                    __builder3.AddMarkupContent(111, "\n                ");
                    __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta.TypeInference.CreateRadzenNumeric_3(__builder3, 112, 113, "width: 100%", 114, "Kolicina", 115, 
#line 53 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                  tblnalogstavkiizmenetum.Kolicina

#line default
#line hidden
                    , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnalogstavkiizmenetum.Kolicina = __value, tblnalogstavkiizmenetum.Kolicina)), 117, () => tblnalogstavkiizmenetum.Kolicina);
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(123, "class", "row");
                    __builder3.AddMarkupContent(124, "\n              ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "col-md-3");
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(128);
                    __builder3.AddAttribute(129, "Text", "Rabat 1");
                    __builder3.AddAttribute(130, "Component", "Rabat1");
                    __builder3.AddAttribute(131, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n              ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "class", "col-md-9");
                    __builder3.AddMarkupContent(136, "\n                ");
                    __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta.TypeInference.CreateRadzenNumeric_4(__builder3, 137, 138, "width: 100%", 139, "Rabat1", 140, 
#line 63 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                  tblnalogstavkiizmenetum.Rabat1

#line default
#line hidden
                    , 141, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnalogstavkiizmenetum.Rabat1 = __value, tblnalogstavkiizmenetum.Rabat1)), 142, () => tblnalogstavkiizmenetum.Rabat1);
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n            ");
                    __builder3.OpenElement(146, "div");
                    __builder3.AddAttribute(147, "class", "row");
                    __builder3.AddMarkupContent(148, "\n              ");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(151, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(152);
                    __builder3.AddAttribute(153, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 69 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(154, "Icon", "save");
                    __builder3.AddAttribute(155, "Text", "Save");
                    __builder3.AddAttribute(156, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 69 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(158);
                    __builder3.AddAttribute(159, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 71 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(160, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(161, "Text", "Cancel");
                    __builder3.AddAttribute(162, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 71 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblNalogStavkiIzmeneta.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(163, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(164, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(165, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(166, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<EditTblNalogStavkiIzmeneta> L { get; set; }
    }
}
namespace __Blazor.Bssr.Pages.EditTblNalogStavkiIzmeneta
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
    }
}
#pragma warning restore 1591
