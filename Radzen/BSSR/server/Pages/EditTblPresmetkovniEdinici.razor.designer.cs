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
    public partial class EditTblPresmetkovniEdiniciComponent : ComponentBase
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
        public dynamic ID { get; set; }

        Bssr.Models.Bssr4.TblPresmetkovniEdinici _tblpresmetkovniedinici;
        protected Bssr.Models.Bssr4.TblPresmetkovniEdinici tblpresmetkovniedinici
        {
            get
            {
                return _tblpresmetkovniedinici;
            }
            set
            {
                if (!object.Equals(_tblpresmetkovniedinici, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblpresmetkovniedinici", NewValue = value, OldValue = _tblpresmetkovniedinici };
                    _tblpresmetkovniedinici = value;
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
            var bssr4GetTblPresmetkovniEdiniciByIdResult = await Bssr4.GetTblPresmetkovniEdiniciById(ID);
            tblpresmetkovniedinici = bssr4GetTblPresmetkovniEdiniciByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblPresmetkovniEdinici args)
        {
            try
            {
                var bssr4UpdateTblPresmetkovniEdiniciResult = await Bssr4.UpdateTblPresmetkovniEdinici(ID, tblpresmetkovniedinici);
                DialogService.Close(tblpresmetkovniedinici);
            }
            catch (System.Exception bssr4UpdateTblPresmetkovniEdiniciException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPresmetkovniEdinici");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
