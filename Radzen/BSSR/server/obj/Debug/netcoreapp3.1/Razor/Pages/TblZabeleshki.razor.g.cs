#pragma checksum "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47a1285d59c009e3209637b90c0bfdf5987a3144"
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
#line 5 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
using Bssr.Models.Bssr4;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-zabeleshki")]
    public partial class TblZabeleshki : Bssr.Pages.TblZabeleshkiComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Zabeleshki");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(14);
                __builder2.AddAttribute(15, "Icon", "get_app");
                __builder2.AddAttribute(16, "style", "margin-left: 0px; margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Export");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#line 14 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                              Splitbutton0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(21);
                    __builder3.AddAttribute(22, "Text", "Excel");
                    __builder3.AddAttribute(23, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(25);
                    __builder3.AddAttribute(26, "Text", "CSV");
                    __builder3.AddAttribute(27, "Value", "csv");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(30);
                __builder2.AddAttribute(31, "Placeholder", "Search ...");
                __builder2.AddAttribute(32, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(33, "Name", "Textbox0");
                __builder2.AddAttribute(34, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 22 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblZabeleshki>>(36);
                __builder2.AddAttribute(37, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(41, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bssr.Models.Bssr4.TblZabeleshki>>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                                                      getTblZabeleshkisResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(42, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                                                                                                                                                                                                                 20

#line default
#line hidden
                ));
                __builder2.AddAttribute(43, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblZabeleshki>>(45);
                    __builder3.AddAttribute(46, "Property", "ID");
                    __builder3.AddAttribute(47, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblZabeleshki>>(49);
                    __builder3.AddAttribute(50, "Property", "Tip");
                    __builder3.AddAttribute(51, "Title", "Tip");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Bssr.Models.Bssr4.TblZabeleshki>>(53);
                    __builder3.AddAttribute(54, "Property", "Zabeleshka");
                    __builder3.AddAttribute(55, "Title", "Zabeleshka");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(57, (__value) => {
#line 24 "C:\Users\spiro\OneDrive\Documents\backupp\BSSR\server\Pages\TblZabeleshki.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Bssr.Models.Bssr4.TblZabeleshki>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591