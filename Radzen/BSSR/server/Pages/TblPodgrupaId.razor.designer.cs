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
    public partial class TblPodgrupaIdComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblPodgrupaId> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblPodgrupaId> _getTblPodgrupaIdsResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPodgrupaId> getTblPodgrupaIdsResult
        {
            get
            {
                return _getTblPodgrupaIdsResult;
            }
            set
            {
                if (!object.Equals(_getTblPodgrupaIdsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPodgrupaIdsResult", NewValue = value, OldValue = _getTblPodgrupaIdsResult };
                    _getTblPodgrupaIdsResult = value;
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

            var bssr4GetTblPodgrupaIdsResult = await Bssr4.GetTblPodgrupaIds(new Query() { Filter = "i => i.Naziv.Contains(@0) || i.Image.Contains(@1)", FilterParameters = new object[] { search, search } });
            getTblPodgrupaIdsResult = bssr4GetTblPodgrupaIdsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblPodgrupaId>("Add Tbl Podgrupa ID", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblPodgrupaIdsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Podgrupa ID");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblPodgrupaIdsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Podgrupa ID");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblPodgrupaId args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblPodgrupaId>("Edit Tbl Podgrupa ID", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblPodgrupaIdResult = await Bssr4.DeleteTblPodgrupaId(data.ID);
                    if (bssr4DeleteTblPodgrupaIdResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblPodgrupaIdException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPodgrupaId");
            }
        }
    }
}
