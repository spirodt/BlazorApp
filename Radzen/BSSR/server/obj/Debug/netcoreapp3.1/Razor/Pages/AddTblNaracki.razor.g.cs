#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff5ccf9b994f7e6604fb40ff0c734bb7612a3437"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-naracki")]
    public partial class AddTblNaracki : Bssr.Pages.AddTblNarackiComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblNaracki>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblNaracki>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                   tblnaracki

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                          tblnaracki != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblNaracki>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblNaracki>(this, 
#line 12 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
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
                    __builder3.AddAttribute(24, "Text", "Naracka Broj");
                    __builder3.AddAttribute(25, "Component", "NarackaBroj");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Bssr.Pages.AddTblNaracki.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "display: block; width: 100%", 34, "NarackaBroj", 35, 
#line 20 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                  tblnaracki.NarackaBroj

#line default
#line hidden
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.NarackaBroj = __value, tblnaracki.NarackaBroj)), 37, () => tblnaracki.NarackaBroj);
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "NarackaBroj");
                    __builder3.AddAttribute(41, "Text", "NarackaBroj is required");
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
                    __builder3.AddAttribute(54, "Text", "Opis");
                    __builder3.AddAttribute(55, "Component", "Opis");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(64, "Name", "Opis");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                  tblnaracki.Opis

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.Opis = __value, tblnaracki.Opis))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblnaracki.Opis));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "Opis");
                    __builder3.AddAttribute(71, "Text", "Opis is required");
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
                    __builder3.AddAttribute(84, "Text", "Datum Na Naracka");
                    __builder3.AddAttribute(85, "Component", "DatumNaNaracka");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-9");
                    __builder3.AddMarkupContent(91, "\n                ");
                    __Blazor.Bssr.Pages.AddTblNaracki.TypeInference.CreateRadzenDatePicker_1(__builder3, 92, 93, "MM/dd/yyyy", 94, "display: block; width: 100%", 95, "DatumNaNaracka", 96, 
#line 44 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                                             tblnaracki.DatumNaNaracka

#line default
#line hidden
                    , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.DatumNaNaracka = __value, tblnaracki.DatumNaNaracka)), 98, () => tblnaracki.DatumNaNaracka);
                    __builder3.AddMarkupContent(99, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(100);
                    __builder3.AddAttribute(101, "Component", "DatumNaNaracka");
                    __builder3.AddAttribute(102, "Text", "DatumNaNaracka is required");
                    __builder3.AddAttribute(103, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(109, "class", "row");
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-3");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
                    __builder3.AddAttribute(115, "Text", "Ime");
                    __builder3.AddAttribute(116, "Component", "Ime");
                    __builder3.AddAttribute(117, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "col-md-9");
                    __builder3.AddMarkupContent(122, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(123);
                    __builder3.AddAttribute(124, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(125, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(126, "Name", "Ime");
                    __builder3.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                                 tblnaracki.Ime

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.Ime = __value, tblnaracki.Ime))));
                    __builder3.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblnaracki.Ime));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(131);
                    __builder3.AddAttribute(132, "Component", "Ime");
                    __builder3.AddAttribute(133, "Text", "Ime is required");
                    __builder3.AddAttribute(134, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\n            ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(140, "class", "row");
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "col-md-3");
                    __builder3.AddMarkupContent(144, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(145);
                    __builder3.AddAttribute(146, "Text", "Kontakt");
                    __builder3.AddAttribute(147, "Component", "Kontakt");
                    __builder3.AddAttribute(148, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(149, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(150, "\n              ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "col-md-9");
                    __builder3.AddMarkupContent(153, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(154);
                    __builder3.AddAttribute(155, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 68 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(156, "style", "width: 100%");
                    __builder3.AddAttribute(157, "Name", "Kontakt");
                    __builder3.AddAttribute(158, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 68 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                 tblnaracki.Kontakt

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(159, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.Kontakt = __value, tblnaracki.Kontakt))));
                    __builder3.AddAttribute(160, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblnaracki.Kontakt));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(161, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\n            ");
                    __builder3.OpenElement(164, "div");
                    __builder3.AddAttribute(165, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(166, "class", "row");
                    __builder3.AddMarkupContent(167, "\n              ");
                    __builder3.OpenElement(168, "div");
                    __builder3.AddAttribute(169, "class", "col-md-3");
                    __builder3.AddMarkupContent(170, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(171);
                    __builder3.AddAttribute(172, "Text", "Od Objekt");
                    __builder3.AddAttribute(173, "Component", "OdObjekt");
                    __builder3.AddAttribute(174, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.OpenElement(177, "div");
                    __builder3.AddAttribute(178, "class", "col-md-9");
                    __builder3.AddMarkupContent(179, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(180);
                    __builder3.AddAttribute(181, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 78 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(182, "style", "width: 100%");
                    __builder3.AddAttribute(183, "Name", "OdObjekt");
                    __builder3.AddAttribute(184, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 78 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                 tblnaracki.OdObjekt

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(185, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.OdObjekt = __value, tblnaracki.OdObjekt))));
                    __builder3.AddAttribute(186, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblnaracki.OdObjekt));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(187, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(188, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(189, "\n            ");
                    __builder3.OpenElement(190, "div");
                    __builder3.AddAttribute(191, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(192, "class", "row");
                    __builder3.AddMarkupContent(193, "\n              ");
                    __builder3.OpenElement(194, "div");
                    __builder3.AddAttribute(195, "class", "col-md-3");
                    __builder3.AddMarkupContent(196, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(197);
                    __builder3.AddAttribute(198, "Text", "Zavrsena");
                    __builder3.AddAttribute(199, "Component", "Zavrsena");
                    __builder3.AddAttribute(200, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(201, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(202, "\n              ");
                    __builder3.OpenElement(203, "div");
                    __builder3.AddAttribute(204, "class", "col-md-9");
                    __builder3.AddMarkupContent(205, "\n                ");
                    __Blazor.Bssr.Pages.AddTblNaracki.TypeInference.CreateRadzenCheckBox_2(__builder3, 206, 207, "Zavrsena", 208, 
#line 88 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                               tblnaracki.Zavrsena

#line default
#line hidden
                    , 209, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.Zavrsena = __value, tblnaracki.Zavrsena)), 210, () => tblnaracki.Zavrsena);
                    __builder3.AddMarkupContent(211, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(212, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(213, "\n            ");
                    __builder3.OpenElement(214, "div");
                    __builder3.AddAttribute(215, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(216, "class", "row");
                    __builder3.AddMarkupContent(217, "\n              ");
                    __builder3.OpenElement(218, "div");
                    __builder3.AddAttribute(219, "class", "col-md-3");
                    __builder3.AddMarkupContent(220, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(221);
                    __builder3.AddAttribute(222, "Text", "Kod Na Dokument");
                    __builder3.AddAttribute(223, "Component", "KodNaDokument");
                    __builder3.AddAttribute(224, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(225, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(226, "\n              ");
                    __builder3.OpenElement(227, "div");
                    __builder3.AddAttribute(228, "class", "col-md-9");
                    __builder3.AddMarkupContent(229, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(230);
                    __builder3.AddAttribute(231, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 98 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                          70

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(232, "style", "width: 100%");
                    __builder3.AddAttribute(233, "Name", "KodNaDokument");
                    __builder3.AddAttribute(234, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 98 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                 tblnaracki.KodNaDokument

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(235, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblnaracki.KodNaDokument = __value, tblnaracki.KodNaDokument))));
                    __builder3.AddAttribute(236, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblnaracki.KodNaDokument));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(237, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(238, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(239, "\n            ");
                    __builder3.OpenElement(240, "div");
                    __builder3.AddAttribute(241, "class", "row");
                    __builder3.AddMarkupContent(242, "\n              ");
                    __builder3.OpenElement(243, "div");
                    __builder3.AddAttribute(244, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(245, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(246);
                    __builder3.AddAttribute(247, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 104 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(248, "Icon", "save");
                    __builder3.AddAttribute(249, "Text", "Save");
                    __builder3.AddAttribute(250, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 104 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(251, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(252);
                    __builder3.AddAttribute(253, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 106 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(254, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(255, "Text", "Cancel");
                    __builder3.AddAttribute(256, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 106 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\AddTblNaracki.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(257, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(258, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(259, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(260, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(261, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(262, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Bssr.Pages.AddTblNaracki
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
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateRadzenCheckBox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
