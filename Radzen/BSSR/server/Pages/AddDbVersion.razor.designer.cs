using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Bssr.Models.Bssr4;
using Microsoft.EntityFrameworkCore;

namespace Bssr.Pages
{
    public partial class AddDbVersionComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

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

        Bssr.Models.Bssr4.DbVersion _dbversion;
        protected Bssr.Models.Bssr4.DbVersion dbversion
        {
            get
            {
                return _dbversion;
            }
            set
            {
                if (!object.Equals(_dbversion, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "dbversion", NewValue = value, OldValue = _dbversion };
                    _dbversion = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            dbversion = new Bssr.Models.Bssr4.DbVersion(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.DbVersion args)
        {
            try
            {
                var bssr4CreateDbVersionResult = await Bssr4.CreateDbVersion(dbversion);
                DialogService.Close(dbversion);
            }
            catch (System.Exception bssr4CreateDbVersionException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new DbVersion!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
