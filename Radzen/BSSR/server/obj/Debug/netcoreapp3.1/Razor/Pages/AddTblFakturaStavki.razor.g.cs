#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8612e74cc8140e2c5db1f951d1675302e136bdbd"
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
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-faktura-stavki")]
    public partial class AddTblFakturaStavki : Bssr.Pages.AddTblFakturaStavkiComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblFakturaStavki>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblFakturaStavki>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                   tblfakturastavki

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                tblfakturastavki != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblFakturaStavki>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblFakturaStavki>(this, 
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
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
                    __builder3.AddAttribute(24, "Text", "Tbl Faktura");
                    __builder3.AddAttribute(25, "Component", "tblFakturaID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 32, 33, 
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                               getTblFakturasFortblFakturaIDResult

#line default
#line hidden
                    , 34, "Zabeleska", 35, "ID", 36, "Choose TblFaktura", 37, 
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                                                                                                            false

#line default
#line hidden
                    , 38, "display: block; width: 100%", 39, "TblFakturaID", 40, 
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                                                                                                                                                                      tblfakturastavki.tblFakturaID

#line default
#line hidden
                    , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.tblFakturaID = __value, tblfakturastavki.tblFakturaID)), 42, () => tblfakturastavki.tblFakturaID);
                    __builder3.AddMarkupContent(43, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(44);
                    __builder3.AddAttribute(45, "Component", "TblFakturaID");
                    __builder3.AddAttribute(46, "Text", "tblFakturaID is required");
                    __builder3.AddAttribute(47, "style", "position: absolute");
                    __builder3.AddAttribute(48, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 23 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                                                                           0

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(54, "class", "row");
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "col-md-3");
                    __builder3.AddMarkupContent(58, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(59);
                    __builder3.AddAttribute(60, "Text", "Tbl Artikal Id");
                    __builder3.AddAttribute(61, "Component", "tblArtikalID");
                    __builder3.AddAttribute(62, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n              ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "col-md-9");
                    __builder3.AddMarkupContent(67, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_1(__builder3, 68, 69, "display: block; width: 100%", 70, "TblArtikalID", 71, 
#line 33 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                  tblfakturastavki.tblArtikalID

#line default
#line hidden
                    , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.tblArtikalID = __value, tblfakturastavki.tblArtikalID)), 73, () => tblfakturastavki.tblArtikalID);
                    __builder3.AddMarkupContent(74, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(75);
                    __builder3.AddAttribute(76, "Component", "TblArtikalID");
                    __builder3.AddAttribute(77, "Text", "tblArtikalID is required");
                    __builder3.AddAttribute(78, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(84, "class", "row");
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-3");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(89);
                    __builder3.AddAttribute(90, "Text", "Normativ");
                    __builder3.AddAttribute(91, "Component", "Normativ");
                    __builder3.AddAttribute(92, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n              ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col-md-9");
                    __builder3.AddMarkupContent(97, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenCheckBox_2(__builder3, 98, 99, "Normativ", 100, 
#line 45 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                               tblfakturastavki.Normativ

#line default
#line hidden
                    , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Normativ = __value, tblfakturastavki.Normativ)), 102, () => tblfakturastavki.Normativ);
                    __builder3.AddMarkupContent(103, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-3");
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(113);
                    __builder3.AddAttribute(114, "Text", "Kolicina");
                    __builder3.AddAttribute(115, "Component", "Kolicina");
                    __builder3.AddAttribute(116, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-md-9");
                    __builder3.AddMarkupContent(121, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_3(__builder3, 122, 123, "display: block; width: 100%", 124, "Kolicina", 125, 
#line 55 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                  tblfakturastavki.Kolicina

#line default
#line hidden
                    , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Kolicina = __value, tblfakturastavki.Kolicina)), 127, () => tblfakturastavki.Kolicina);
                    __builder3.AddMarkupContent(128, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(129);
                    __builder3.AddAttribute(130, "Component", "Kolicina");
                    __builder3.AddAttribute(131, "Text", "Kolicina is required");
                    __builder3.AddAttribute(132, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\n            ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(138, "class", "row");
                    __builder3.AddMarkupContent(139, "\n              ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col-md-3");
                    __builder3.AddMarkupContent(142, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(143);
                    __builder3.AddAttribute(144, "Text", "Iznos");
                    __builder3.AddAttribute(145, "Component", "Iznos");
                    __builder3.AddAttribute(146, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(147, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\n              ");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "col-md-9");
                    __builder3.AddMarkupContent(151, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_4(__builder3, 152, 153, "display: block; width: 100%", 154, "Iznos", 155, 
#line 67 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                  tblfakturastavki.Iznos

#line default
#line hidden
                    , 156, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Iznos = __value, tblfakturastavki.Iznos)), 157, () => tblfakturastavki.Iznos);
                    __builder3.AddMarkupContent(158, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(159);
                    __builder3.AddAttribute(160, "Component", "Iznos");
                    __builder3.AddAttribute(161, "Text", "Iznos is required");
                    __builder3.AddAttribute(162, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(163, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(164, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(165, "\n            ");
                    __builder3.OpenElement(166, "div");
                    __builder3.AddAttribute(167, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(168, "class", "row");
                    __builder3.AddMarkupContent(169, "\n              ");
                    __builder3.OpenElement(170, "div");
                    __builder3.AddAttribute(171, "class", "col-md-3");
                    __builder3.AddMarkupContent(172, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(173);
                    __builder3.AddAttribute(174, "Text", "Rabat 1");
                    __builder3.AddAttribute(175, "Component", "Rabat1");
                    __builder3.AddAttribute(176, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(178, "\n              ");
                    __builder3.OpenElement(179, "div");
                    __builder3.AddAttribute(180, "class", "col-md-9");
                    __builder3.AddMarkupContent(181, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_5(__builder3, 182, 183, "width: 100%", 184, "Rabat1", 185, 
#line 79 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                  tblfakturastavki.Rabat1

#line default
#line hidden
                    , 186, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Rabat1 = __value, tblfakturastavki.Rabat1)), 187, () => tblfakturastavki.Rabat1);
                    __builder3.AddMarkupContent(188, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(189, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(190, "\n            ");
                    __builder3.OpenElement(191, "div");
                    __builder3.AddAttribute(192, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(193, "class", "row");
                    __builder3.AddMarkupContent(194, "\n              ");
                    __builder3.OpenElement(195, "div");
                    __builder3.AddAttribute(196, "class", "col-md-3");
                    __builder3.AddMarkupContent(197, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(198);
                    __builder3.AddAttribute(199, "Text", "Rabat 2");
                    __builder3.AddAttribute(200, "Component", "Rabat2");
                    __builder3.AddAttribute(201, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(202, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(203, "\n              ");
                    __builder3.OpenElement(204, "div");
                    __builder3.AddAttribute(205, "class", "col-md-9");
                    __builder3.AddMarkupContent(206, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_6(__builder3, 207, 208, "width: 100%", 209, "Rabat2", 210, 
#line 89 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                  tblfakturastavki.Rabat2

#line default
#line hidden
                    , 211, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Rabat2 = __value, tblfakturastavki.Rabat2)), 212, () => tblfakturastavki.Rabat2);
                    __builder3.AddMarkupContent(213, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(214, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(215, "\n            ");
                    __builder3.OpenElement(216, "div");
                    __builder3.AddAttribute(217, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(218, "class", "row");
                    __builder3.AddMarkupContent(219, "\n              ");
                    __builder3.OpenElement(220, "div");
                    __builder3.AddAttribute(221, "class", "col-md-3");
                    __builder3.AddMarkupContent(222, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(223);
                    __builder3.AddAttribute(224, "Text", "Rabat 3");
                    __builder3.AddAttribute(225, "Component", "Rabat3");
                    __builder3.AddAttribute(226, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(227, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(228, "\n              ");
                    __builder3.OpenElement(229, "div");
                    __builder3.AddAttribute(230, "class", "col-md-9");
                    __builder3.AddMarkupContent(231, "\n                ");
                    __Blazor.Bssr.Pages.AddTblFakturaStavki.TypeInference.CreateRadzenNumeric_7(__builder3, 232, 233, "width: 100%", 234, "Rabat3", 235, 
#line 99 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                  tblfakturastavki.Rabat3

#line default
#line hidden
                    , 236, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblfakturastavki.Rabat3 = __value, tblfakturastavki.Rabat3)), 237, () => tblfakturastavki.Rabat3);
                    __builder3.AddMarkupContent(238, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(239, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(240, "\n            ");
                    __builder3.OpenElement(241, "div");
                    __builder3.AddAttribute(242, "class", "row");
                    __builder3.AddMarkupContent(243, "\n              ");
                    __builder3.OpenElement(244, "div");
                    __builder3.AddAttribute(245, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(246, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(247);
                    __builder3.AddAttribute(248, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 105 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(249, "Icon", "save");
                    __builder3.AddAttribute(250, "Text", "Save");
                    __builder3.AddAttribute(251, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 105 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(252, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(253);
                    __builder3.AddAttribute(254, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 107 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(255, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(256, "Text", "Cancel");
                    __builder3.AddAttribute(257, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 107 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddTblFakturaStavki.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(258, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(259, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(260, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(261, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(262, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(263, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddTblFakturaStavki> L { get; set; }
    }
}
namespace __Blazor.Bssr.Pages.AddTblFakturaStavki
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, System.Object __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "style", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
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
        public static void CreateRadzenCheckBox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
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
        public static void CreateRadzenNumeric_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
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
        public static void CreateRadzenNumeric_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
