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
    public partial class ChangelogComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.Changelog> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.Changelog> _getChangelogsResult;
        protected IEnumerable<Bssr.Models.Bssr4.Changelog> getChangelogsResult
        {
            get
            {
                return _getChangelogsResult;
            }
            set
            {
                if (!object.Equals(_getChangelogsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getChangelogsResult", NewValue = value, OldValue = _getChangelogsResult };
                    _getChangelogsResult = value;
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
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var bssr4GetChangelogsResult = await Bssr4.GetChangelogs(new Query() { Filter = "i => i.applied_by.Contains(@0) || i.description.Contains(@1)", FilterParameters = new object[] { search, search } });
            getChangelogsResult = bssr4GetChangelogsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddChangelog>("Add Changelog", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportChangelogsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Changelog");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportChangelogsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Changelog");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.Changelog args)
        {
            var dialogResult = await DialogService.OpenAsync<EditChangelog>("Edit Changelog", new Dictionary<string, object>() { {"change_number", args.change_number} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteChangelogResult = await Bssr4.DeleteChangelog(data.change_number);
                    if (bssr4DeleteChangelogResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteChangelogException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Changelog");
            }
        }
    }
}
