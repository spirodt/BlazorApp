#pragma checksum "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01108fe918dc67d5f6c6419cfbdc7dee630c9fcc"
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
#line 5 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-dokumenti")]
    public partial class TblDokumenti : Bssr.Pages.TblDokumentiComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Dokumenti");
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
#line 15 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
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
#line 17 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
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
#line 25 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblDokumenti>>(42);
                __builder2.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblDokumenti>>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                      getTblDokumentisResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(48, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                                                                                               20

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblDokumenti>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblDokumenti>(this, 
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                                                                                                               Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(52);
                    __builder3.AddAttribute(53, "Property", "ID");
                    __builder3.AddAttribute(54, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(56);
                    __builder3.AddAttribute(57, "Property", "Broj");
                    __builder3.AddAttribute(58, "Title", "Broj");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(60);
                    __builder3.AddAttribute(61, "Property", "TipNaDokument");
                    __builder3.AddAttribute(62, "SortProperty", "TblTipNaDokument.Naziv");
                    __builder3.AddAttribute(63, "FilterProperty", "TblTipNaDokument.Naziv");
                    __builder3.AddAttribute(64, "Title", "Tbl Tip Na Dokument");
                    __builder3.AddAttribute(65, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblDokumenti>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(66, "\n              ");
                        __builder4.AddContent(67, 
#line 35 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                data.TblTipNaDokument?.Naziv

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(68, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(70);
                    __builder3.AddAttribute(71, "Property", "Datum");
                    __builder3.AddAttribute(72, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(73, "Title", "Datum");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(75);
                    __builder3.AddAttribute(76, "Property", "OdObjektID");
                    __builder3.AddAttribute(77, "Title", "Od Objekt ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(79);
                    __builder3.AddAttribute(80, "Property", "DoObjektID");
                    __builder3.AddAttribute(81, "Title", "Do Objekt ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(83);
                    __builder3.AddAttribute(84, "Property", "tblUserID");
                    __builder3.AddAttribute(85, "Title", "Tbl User ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(87);
                    __builder3.AddAttribute(88, "Property", "Zabeleska");
                    __builder3.AddAttribute(89, "Title", "Zabeleska");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(91);
                    __builder3.AddAttribute(92, "Property", "tblPartnerID");
                    __builder3.AddAttribute(93, "SortProperty", "TblPartneri.Sifra");
                    __builder3.AddAttribute(94, "FilterProperty", "TblPartneri.Sifra");
                    __builder3.AddAttribute(95, "Title", "Tbl Partneri");
                    __builder3.AddAttribute(96, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblDokumenti>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(97, "\n              ");
                        __builder4.AddContent(98, 
#line 50 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                data.TblPartneri?.Sifra

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(99, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(101);
                    __builder3.AddAttribute(102, "Property", "FirmaID");
                    __builder3.AddAttribute(103, "Title", "Firma ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(105);
                    __builder3.AddAttribute(106, "Property", "KodNaDokument");
                    __builder3.AddAttribute(107, "Title", "Kod Na Dokument");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(109);
                    __builder3.AddAttribute(110, "Property", "BrojNaDokument");
                    __builder3.AddAttribute(111, "Title", "Broj Na Dokument");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblDokumenti>>(113);
                    __builder3.AddAttribute(114, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 59 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(115, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 59 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(116, "Width", "70px");
                    __builder3.AddAttribute(117, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 59 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                 TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(118, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblDokumenti>)((bssrModelsBssr4TblDokumenti) => (__builder4) => {
                        __builder4.AddMarkupContent(119, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(120);
                        __builder4.AddAttribute(121, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(122, "Icon", "close");
                        __builder4.AddAttribute(123, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(124, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, bssrModelsBssr4TblDokumenti)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(125, "onclick", 
#line 61 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                                                                                                                                                                                                           true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(126, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(128, (__value) => {
#line 27 "C:\Projects\blazor\BlazorApp\Radzen\BSSR\server\Pages\TblDokumenti.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblDokumenti>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(129, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<TblDokumenti> L { get; set; }
    }
}
#pragma warning restore 1591
