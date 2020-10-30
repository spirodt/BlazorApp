using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Bssr.Models.Bssr4;
using Microsoft.JSInterop;

namespace Bssr.Layouts
{
    public partial class MainLayoutComponent : LayoutComponentBase
    {
        [Inject]
        protected Microsoft.JSInterop.IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }
        
        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected Bssr4Service Bssr4 { get; set; }

        protected RadzenBody body0;
        protected RadzenSidebar sidebar0;


        protected async System.Threading.Tasks.Task SidebarToggle0Click(dynamic args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });

            await InvokeAsync(() => { body0.Toggle(); });
        }
    }
}
