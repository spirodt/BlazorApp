#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc8f89586eb2c3418044378c9c0a2de6d75b5987"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-smetka-izmeneta")]
    public partial class TblSmetkaIzmeneta : Bssr.Pages.TblSmetkaIzmenetaComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Smetka Izmeneta");
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
#line 14 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
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
#line 16 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
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
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(42);
                __builder2.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                      getTblSmetkaIzmenetaResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(48, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                                                                                                         20

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblSmetkaIzmenetum>(this, 
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                                                                                                                         Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(52);
                    __builder3.AddAttribute(53, "Property", "ID");
                    __builder3.AddAttribute(54, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(56);
                    __builder3.AddAttribute(57, "Property", "Broj");
                    __builder3.AddAttribute(58, "Title", "Broj");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(60);
                    __builder3.AddAttribute(61, "Property", "DatumPocetok");
                    __builder3.AddAttribute(62, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(63, "Title", "Datum Pocetok");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(65);
                    __builder3.AddAttribute(66, "Property", "DatumKraj");
                    __builder3.AddAttribute(67, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(68, "Title", "Datum Kraj");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(70);
                    __builder3.AddAttribute(71, "Property", "tblUserID");
                    __builder3.AddAttribute(72, "Title", "Tbl User ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(74);
                    __builder3.AddAttribute(75, "Property", "Smena_ID");
                    __builder3.AddAttribute(76, "Title", "Smena ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(78);
                    __builder3.AddAttribute(79, "Property", "Zatvorena");
                    __builder3.AddAttribute(80, "Title", "Zatvorena");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(82);
                    __builder3.AddAttribute(83, "Property", "FirmaID");
                    __builder3.AddAttribute(84, "Title", "Firma ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(86);
                    __builder3.AddAttribute(87, "Property", "ObjektID");
                    __builder3.AddAttribute(88, "Title", "Objekt ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(90);
                    __builder3.AddAttribute(91, "Property", "Zabeleska");
                    __builder3.AddAttribute(92, "Title", "Zabeleska");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(94);
                    __builder3.AddAttribute(95, "Property", "Izmeneta");
                    __builder3.AddAttribute(96, "Title", "Izmeneta");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(98);
                    __builder3.AddAttribute(99, "Property", "DatumNaIzmena");
                    __builder3.AddAttribute(100, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(101, "Title", "Datum Na Izmena");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(103);
                    __builder3.AddAttribute(104, "Property", "tblSmetkaIzmenetaID");
                    __builder3.AddAttribute(105, "Title", "Tbl Smetka Izmeneta ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(107);
                    __builder3.AddAttribute(108, "Property", "tblPartnerID");
                    __builder3.AddAttribute(109, "Title", "Tbl Partner ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(110, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblSmetkaIzmenetum>>(111);
                    __builder3.AddAttribute(112, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(113, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(114, "Width", "70px");
                    __builder3.AddAttribute(115, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 56 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(116, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblSmetkaIzmenetum>)((bssrModelsBssr4TblSmetkaIzmenetum) => (__builder4) => {
                        __builder4.AddMarkupContent(117, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(118);
                        __builder4.AddAttribute(119, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(120, "Icon", "close");
                        __builder4.AddAttribute(121, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 58 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(122, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, bssrModelsBssr4TblSmetkaIzmenetum)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(123, "onclick", 
#line 58 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                                                                                                                                                                                                                 true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(124, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(126, (__value) => {
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblSmetkaIzmeneta.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblSmetkaIzmenetum>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591