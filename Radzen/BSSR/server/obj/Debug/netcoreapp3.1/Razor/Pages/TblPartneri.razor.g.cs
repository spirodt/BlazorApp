#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828784a8db9c2eb6de0d5fde3a535aeba28f777d"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-partneri")]
    public partial class TblPartneri : Bssr.Pages.TblPartneriComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Partneri");
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
#line 14 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
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
#line 16 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
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
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblPartneri>>(42);
                __builder2.AddAttribute(43, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblPartneri>>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                      getTblPartnerisResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(48, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                                                                                             20

#line default
#line hidden
                ));
                __builder2.AddAttribute(49, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Bssr.Models.Bssr4.TblPartneri>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Bssr.Models.Bssr4.TblPartneri>(this, 
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                                                                                                             Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(50, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(52);
                    __builder3.AddAttribute(53, "Property", "ID");
                    __builder3.AddAttribute(54, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(56);
                    __builder3.AddAttribute(57, "Property", "Sifra");
                    __builder3.AddAttribute(58, "Title", "Sifra");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(60);
                    __builder3.AddAttribute(61, "Property", "Naziv");
                    __builder3.AddAttribute(62, "Title", "Naziv");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(64);
                    __builder3.AddAttribute(65, "Property", "Adresa");
                    __builder3.AddAttribute(66, "Title", "Adresa");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(68);
                    __builder3.AddAttribute(69, "Property", "Telefoni");
                    __builder3.AddAttribute(70, "Title", "Telefoni");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(72);
                    __builder3.AddAttribute(73, "Property", "Email");
                    __builder3.AddAttribute(74, "Title", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(76);
                    __builder3.AddAttribute(77, "Property", "EDB");
                    __builder3.AddAttribute(78, "Title", "EDB");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(80);
                    __builder3.AddAttribute(81, "Property", "Mesto");
                    __builder3.AddAttribute(82, "Title", "Mesto");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(84);
                    __builder3.AddAttribute(85, "Property", "Tip");
                    __builder3.AddAttribute(86, "Title", "Tip");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(88);
                    __builder3.AddAttribute(89, "Property", "Status");
                    __builder3.AddAttribute(90, "Title", "Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(92);
                    __builder3.AddAttribute(93, "Property", "FirmaID");
                    __builder3.AddAttribute(94, "Title", "Firma ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(96);
                    __builder3.AddAttribute(97, "Property", "tblPresmetkovnaEdinicaID");
                    __builder3.AddAttribute(98, "Title", "Tbl Presmetkovna Edinica ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblPartneri>>(100);
                    __builder3.AddAttribute(101, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 52 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(102, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 52 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(103, "Width", "70px");
                    __builder3.AddAttribute(104, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 52 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(105, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Bssr.Models.Bssr4.TblPartneri>)((bssrModelsBssr4TblPartneri) => (__builder4) => {
                        __builder4.AddMarkupContent(106, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(107);
                        __builder4.AddAttribute(108, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(109, "Icon", "close");
                        __builder4.AddAttribute(110, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(111, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, bssrModelsBssr4TblPartneri)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(112, "onclick", 
#line 54 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                                                                                                                                                                                                          true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(113, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(115, (__value) => {
#line 26 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblPartneri.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblPartneri>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
