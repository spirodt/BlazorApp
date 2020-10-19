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
    public partial class TblPresmetkovniEdiniciComponent : ComponentBase
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
        protected RadzenGrid<Bssr.Models.Bssr4.TblPresmetkovniEdinici> grid0;

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

        IEnumerable<Bssr.Models.Bssr4.TblPresmetkovniEdinici> _getTblPresmetkovniEdinicisResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPresmetkovniEdinici> getTblPresmetkovniEdinicisResult
        {
            get
            {
                return _getTblPresmetkovniEdinicisResult;
            }
            set
            {
                if (!object.Equals(_getTblPresmetkovniEdinicisResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPresmetkovniEdinicisResult", NewValue = value, OldValue = _getTblPresmetkovniEdinicisResult };
                    _getTblPresmetkovniEdinicisResult = value;
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

            var bssr4GetTblPresmetkovniEdinicisResult = await Bssr4.GetTblPresmetkovniEdinicis(new Query() { Filter = "i => i.Sifra.Contains(@0) || i.Naziv.Contains(@1) || i.Zabeleska.Contains(@2)", FilterParameters = new object[] { search, search, search } });
            getTblPresmetkovniEdinicisResult = bssr4GetTblPresmetkovniEdinicisResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblPresmetkovniEdinici>("Add Tbl Presmetkovni Edinici", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Bssr4.ExportTblPresmetkovniEdinicisToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Presmetkovni Edinici");

            }

            if (args?.Value == "xlsx")
            {
                await Bssr4.ExportTblPresmetkovniEdinicisToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Tbl Presmetkovni Edinici");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Bssr.Models.Bssr4.TblPresmetkovniEdinici args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblPresmetkovniEdinici>("Edit Tbl Presmetkovni Edinici", new Dictionary<string, object>() { {"ID", args.ID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var bssr4DeleteTblPresmetkovniEdiniciResult = await Bssr4.DeleteTblPresmetkovniEdinici(data.ID);
                    if (bssr4DeleteTblPresmetkovniEdiniciResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception bssr4DeleteTblPresmetkovniEdiniciException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblPresmetkovniEdinici");
            }
        }
    }
}
