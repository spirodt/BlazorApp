#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c910ef6ad01a69342a4c2ae5f9c9c552d7538c5"
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
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-prevodi/{ID}")]
    public partial class EditTblPrevodi : Bssr.Pages.EditTblPrevodiComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.TblPrevodi>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.TblPrevodi>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                        tblprevodi

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                               tblprevodi != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblPrevodi>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblPrevodi>(this, 
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
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
                    __builder3.AddAttribute(24, "Text", "Klucen Zbor");
                    __builder3.AddAttribute(25, "Component", "KlucenZbor");
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
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          150

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "KlucenZbor");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                  tblprevodi.KlucenZbor

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblprevodi.KlucenZbor = __value, tblprevodi.KlucenZbor))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblprevodi.KlucenZbor));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(44, "class", "row");
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-3");
                    __builder3.AddMarkupContent(48, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", "Mk");
                    __builder3.AddAttribute(51, "Component", "MK");
                    __builder3.AddAttribute(52, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-9");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(58);
                    __builder3.AddAttribute(59, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 31 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "style", "width: 100%");
                    __builder3.AddAttribute(61, "Name", "MK");
                    __builder3.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 31 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                  tblprevodi.MK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblprevodi.MK = __value, tblprevodi.MK))));
                    __builder3.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblprevodi.MK));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(70, "class", "row");
                    __builder3.AddMarkupContent(71, "\n              ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col-md-3");
                    __builder3.AddMarkupContent(74, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(75);
                    __builder3.AddAttribute(76, "Text", "Al");
                    __builder3.AddAttribute(77, "Component", "AL");
                    __builder3.AddAttribute(78, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-9");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(84);
                    __builder3.AddAttribute(85, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 41 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.AddAttribute(87, "Name", "AL");
                    __builder3.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 41 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                  tblprevodi.AL

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblprevodi.AL = __value, tblprevodi.AL))));
                    __builder3.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblprevodi.AL));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(96, "class", "row");
                    __builder3.AddMarkupContent(97, "\n              ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col-md-3");
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(101);
                    __builder3.AddAttribute(102, "Text", "En");
                    __builder3.AddAttribute(103, "Component", "EN");
                    __builder3.AddAttribute(104, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "col-md-9");
                    __builder3.AddMarkupContent(109, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(110);
                    __builder3.AddAttribute(111, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 51 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(112, "style", "width: 100%");
                    __builder3.AddAttribute(113, "Name", "EN");
                    __builder3.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 51 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                  tblprevodi.EN

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblprevodi.EN = __value, tblprevodi.EN))));
                    __builder3.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblprevodi.EN));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(122, "class", "row");
                    __builder3.AddMarkupContent(123, "\n              ");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col-md-3");
                    __builder3.AddMarkupContent(126, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(127);
                    __builder3.AddAttribute(128, "Text", "Sr");
                    __builder3.AddAttribute(129, "Component", "SR");
                    __builder3.AddAttribute(130, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "class", "col-md-9");
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(136);
                    __builder3.AddAttribute(137, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          250

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.AddAttribute(139, "Name", "SR");
                    __builder3.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                  tblprevodi.SR

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(141, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblprevodi.SR = __value, tblprevodi.SR))));
                    __builder3.AddAttribute(142, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tblprevodi.SR));
                    __builder3.CloseComponent();
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
#line 67 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(154, "Icon", "save");
                    __builder3.AddAttribute(155, "Text", "Save");
                    __builder3.AddAttribute(156, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 67 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(158);
                    __builder3.AddAttribute(159, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 69 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(160, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(161, "Text", "Cancel");
                    __builder3.AddAttribute(162, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 69 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\EditTblPrevodi.razor"
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<EditTblPrevodi> L { get; set; }
    }
}
#pragma warning restore 1591
