#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "442ef7b04ebd29db873e09266f5312df8917060c"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-nalog-stavki")]
    public partial class TblNalogStavki : Bssr.Pages.TblNalogStavkiComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Nalog Stavki");
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
#line 14 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
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
#line 16 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
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
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblNalogStavki>>(42);
                __builder2.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblNalogStavki>>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                      getTblNalogStavkisResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(48, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                                                                                                   20

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblNalogStavki>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblNalogStavki>(this, 
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                                                                                                                   Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(52);
                    __builder3.AddAttribute(53, "Property", "ID");
                    __builder3.AddAttribute(54, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(56);
                    __builder3.AddAttribute(57, "Property", "tblNalogID");
                    __builder3.AddAttribute(58, "SortProperty", "TblNalog.Zabeleska");
                    __builder3.AddAttribute(59, "FilterProperty", "TblNalog.Zabeleska");
                    __builder3.AddAttribute(60, "Title", "Tbl Nalog");
                    __builder3.AddAttribute(61, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblNalogStavki>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(62, "\n              ");
                        __builder4.AddContent(63, 
#line 32 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                data.TblNalog?.Zabeleska

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(64, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(66);
                    __builder3.AddAttribute(67, "Property", "tblNomativID");
                    __builder3.AddAttribute(68, "SortProperty", "TblNormativ.Naziv");
                    __builder3.AddAttribute(69, "FilterProperty", "TblNormativ.Naziv");
                    __builder3.AddAttribute(70, "Title", "Tbl Normativ");
                    __builder3.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblNalogStavki>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(72, "\n              ");
                        __builder4.AddContent(73, 
#line 37 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                data.TblNormativ?.Naziv

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(74, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(76);
                    __builder3.AddAttribute(77, "Property", "tblArtikalID");
                    __builder3.AddAttribute(78, "SortProperty", "TblArtikal.Sifra");
                    __builder3.AddAttribute(79, "FilterProperty", "TblArtikal.Sifra");
                    __builder3.AddAttribute(80, "Title", "Tbl Artikal");
                    __builder3.AddAttribute(81, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblNalogStavki>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(82, "\n              ");
                        __builder4.AddContent(83, 
#line 42 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                data.TblArtikal?.Sifra

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(84, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(86);
                    __builder3.AddAttribute(87, "Property", "Kolicina");
                    __builder3.AddAttribute(88, "Title", "Kolicina");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(90);
                    __builder3.AddAttribute(91, "Property", "Rabat1");
                    __builder3.AddAttribute(92, "Title", "Rabat 1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblNalogStavki>>(94);
                    __builder3.AddAttribute(95, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 49 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 49 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(97, "Width", "70px");
                    __builder3.AddAttribute(98, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 49 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                   TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(99, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblNalogStavki>)((bssrModelsBssr4TblNalogStavki) => (__builder4) => {
                        __builder4.AddMarkupContent(100, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(101);
                        __builder4.AddAttribute(102, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 51 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(103, "Icon", "close");
                        __builder4.AddAttribute(104, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 51 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(105, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 51 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, bssrModelsBssr4TblNalogStavki)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(106, "onclick", 
#line 51 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                                                                                                                                                                                                             true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(109, (__value) => {
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblNalogStavki.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblNalogStavki>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591