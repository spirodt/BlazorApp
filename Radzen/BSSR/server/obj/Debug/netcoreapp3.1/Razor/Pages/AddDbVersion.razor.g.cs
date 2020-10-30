#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a059853ca7845ad85824883a07455059e2beb54"
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
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-db-version")]
    public partial class AddDbVersion : Bssr.Pages.AddDbVersionComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Bssr.Models.Bssr4.DbVersion>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Bssr.Models.Bssr4.DbVersion>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                   dbversion

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                                         dbversion != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.DbVersion>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.DbVersion>(this, 
#line 13 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
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
                    __builder3.AddAttribute(24, "Text", "Db Version");
                    __builder3.AddAttribute(25, "Component", "DbVersion1");
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
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                          30

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "DbVersion1");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 21 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                                                                 dbversion.DbVersion1

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dbversion.DbVersion1 = __value, dbversion.DbVersion1))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dbversion.DbVersion1));
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
                    __builder3.AddAttribute(50, "Text", "Last Alter Script Name");
                    __builder3.AddAttribute(51, "Component", "LastAlterScriptName");
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
#line 31 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(61, "Name", "LastAlterScriptName");
                    __builder3.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 31 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                                                                                 dbversion.LastAlterScriptName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dbversion.LastAlterScriptName = __value, dbversion.LastAlterScriptName))));
                    __builder3.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dbversion.LastAlterScriptName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(66);
                    __builder3.AddAttribute(67, "Component", "LastAlterScriptName");
                    __builder3.AddAttribute(68, "Text", "LastAlterScriptName is required");
                    __builder3.AddAttribute(69, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "class", "row");
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(78, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(79);
                    __builder3.AddAttribute(80, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 39 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(81, "Icon", "save");
                    __builder3.AddAttribute(82, "Text", "Save");
                    __builder3.AddAttribute(83, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 39 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(85);
                    __builder3.AddAttribute(86, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 41 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(88, "Text", "Cancel");
                    __builder3.AddAttribute(89, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 41 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\AddDbVersion.razor"
                                                                                                              Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddDbVersion> L { get; set; }
    }
}
#pragma warning restore 1591
