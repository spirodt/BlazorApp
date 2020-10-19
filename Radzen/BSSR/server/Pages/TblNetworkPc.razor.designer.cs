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
    public partial class TblNetworkPcComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblNetworkPc> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblNetworkPc> _getTblNetworkPcsResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblNetworkPc> getTblNetworkPcsResult
        {
            get
            {
                return _getTblNetworkPcsResult;
            }
            set
            {
                if (!object.Equals(_getTblNetworkPcsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblNetworkPcsResult", NewValue = value, OldValue = _getTblNetworkPcsResult };
                    _getTblNetworkPcsResult = value;
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

            var bssr4GetTblNetworkPcsResult = await Bssr4.GetTblNetworkPcs(new Query() { Filter = "i => i.PCName.Contains(@0) || i.HostName.Contains(@1) || i.IPAddres.Contains(@2) || i.R_UserName.Contains(@3) || i.R_PassWord.Contains(@4) || i.ClientPassword.Contains(@5) || i.Grupa.Contains(@6)", FilterParameters = new object[] { search, search, search, search, search, search, search } });
            getTblNetworkPcsResult = bssr4GetTblNetworkPcsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblNetworkPc>("Add Tbl Network PC", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblNetworkPcsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Network PC");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblNetworkPcsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Network PC");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblNetworkPc args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblNetworkPc>("Edit Tbl Network PC", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblNetworkPcResult = await Bssr4.DeleteTblNetworkPc(data.ID);
                    if (bssr4DeleteTblNetworkPcResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblNetworkPcException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblNetworkPc");
            }
        }
    }
}
