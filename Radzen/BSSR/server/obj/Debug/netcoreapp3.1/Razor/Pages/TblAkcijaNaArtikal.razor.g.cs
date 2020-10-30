#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc5a54e5ddd6a341f68c3c91157f21502a6c0a68"
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
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-akcija-na-artikal")]
    public partial class TblAkcijaNaArtikal : Bssr.Pages.TblAkcijaNaArtikalComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Akcija Na Artikal");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(20);
                __builder2.AddAttribute(21, "Icon", "get_app");
                __builder2.AddAttribute(22, "style", "margin-left: 10px; margin-bottom: 10px");
                __builder2.AddAttribute(23, "Text", "Export");
                __builder2.AddAttribute(24, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#line 17 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "Excel");
                    __builder3.AddAttribute(29, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(31);
                    __builder3.AddAttribute(32, "Text", "CSV");
                    __builder3.AddAttribute(33, "Value", "csv");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(36);
                __builder2.AddAttribute(37, "Placeholder", "Search ...");
                __builder2.AddAttribute(38, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(39, "Name", "Textbox0");
                __builder2.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 25 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(42);
                __builder2.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                      getTblAkcijaNaArtikalsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(48, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                                                                                                           20

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblAkcijaNaArtikal>(this, 
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(52);
                    __builder3.AddAttribute(53, "Property", "ID");
                    __builder3.AddAttribute(54, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(56);
                    __builder3.AddAttribute(57, "Property", "DatumPocetok");
                    __builder3.AddAttribute(58, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(59, "Title", "Datum Pocetok");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(61);
                    __builder3.AddAttribute(62, "Property", "DatumKraj");
                    __builder3.AddAttribute(63, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(64, "Title", "Datum Kraj");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(66);
                    __builder3.AddAttribute(67, "Property", "tblArtikalID");
                    __builder3.AddAttribute(68, "SortProperty", "TblArtikal.Sifra");
                    __builder3.AddAttribute(69, "FilterProperty", "TblArtikal.Sifra");
                    __builder3.AddAttribute(70, "Title", "Tbl Artikal");
                    __builder3.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblAkcijaNaArtikal>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(72, "\n              ");
                        __builder4.AddContent(73, 
#line 37 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                data.TblArtikal?.Sifra

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(74, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(76);
                    __builder3.AddAttribute(77, "Property", "AkciskaCena");
                    __builder3.AddAttribute(78, "Title", "Akciska Cena");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(80);
                    __builder3.AddAttribute(81, "Property", "Rabat");
                    __builder3.AddAttribute(82, "Title", "Rabat");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblAkcijaNaArtikal>>(84);
                    __builder3.AddAttribute(85, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 44 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 44 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "Width", "70px");
                    __builder3.AddAttribute(88, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 44 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(89, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblAkcijaNaArtikal>)((bssrModelsBssr4TblAkcijaNaArtikal) => (__builder4) => {
                        __builder4.AddMarkupContent(90, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(91);
                        __builder4.AddAttribute(92, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 46 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(93, "Icon", "close");
                        __builder4.AddAttribute(94, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 46 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(95, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 46 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, bssrModelsBssr4TblAkcijaNaArtikal)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(96, "onclick", 
#line 46 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                                                                                                                                                                                                                 true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(97, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(99, (__value) => {
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblAkcijaNaArtikal.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblAkcijaNaArtikal>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<TblAkcijaNaArtikal> L { get; set; }
    }
}
#pragma warning restore 1591
