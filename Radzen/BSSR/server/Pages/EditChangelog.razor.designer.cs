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
    public partial class EditChangelogComponent : ComponentBase
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

        [Parameter]
        public dynamic change_number { get; set; }

        Bssr.Models.Bssr4.Changelog _changelog;
        protected Bssr.Models.Bssr4.Changelog changelog
        {
            get
            {
                return _changelog;
            }
            set
            {
                if (!object.Equals(_changelog, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "changelog", NewValue = value, OldValue = _changelog };
                    _changelog = value;
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
            var bssr4GetChangelogBychangeNumberResult = await Bssr4.GetChangelogBychangeNumber(change_number);
            changelog = bssr4GetChangelogBychangeNumberResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.Changelog args)
        {
            try
            {
                var bssr4UpdateChangelogResult = await Bssr4.UpdateChangelog(change_number, changelog);
                DialogService.Close(changelog);
            }
            catch (System.Exception bssr4UpdateChangelogException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Changelog");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
