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
    public partial class AddTblKnizenjeMComponent : ComponentBase
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

        IEnumerable<Bssr.Models.Bssr4.TblSmetka> _getTblSmetkasFortblSmetkaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblSmetka> getTblSmetkasFortblSmetkaIDResult
        {
            get
            {
                return _getTblSmetkasFortblSmetkaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblSmetkasFortblSmetkaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblSmetkasFortblSmetkaIDResult", NewValue = value, OldValue = _getTblSmetkasFortblSmetkaIDResult };
                    _getTblSmetkasFortblSmetkaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblFaktura> _getTblFakturasFortblFakturaIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblFaktura> getTblFakturasFortblFakturaIDResult
        {
            get
            {
                return _getTblFakturasFortblFakturaIDResult;
            }
            set
            {
                if (!object.Equals(_getTblFakturasFortblFakturaIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblFakturasFortblFakturaIDResult", NewValue = value, OldValue = _getTblFakturasFortblFakturaIDResult };
                    _getTblFakturasFortblFakturaIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblPriem> _getTblPriemsFortblPriemIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblPriem> getTblPriemsFortblPriemIDResult
        {
            get
            {
                return _getTblPriemsFortblPriemIDResult;
            }
            set
            {
                if (!object.Equals(_getTblPriemsFortblPriemIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblPriemsFortblPriemIDResult", NewValue = value, OldValue = _getTblPriemsFortblPriemIDResult };
                    _getTblPriemsFortblPriemIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Bssr.Models.Bssr4.TblDokumenti> _getTblDokumentisFortblDokumentIDResult;
        protected IEnumerable<Bssr.Models.Bssr4.TblDokumenti> getTblDokumentisFortblDokumentIDResult
        {
            get
            {
                return _getTblDokumentisFortblDokumentIDResult;
            }
            set
            {
                if (!object.Equals(_getTblDokumentisFortblDokumentIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTblDokumentisFortblDokumentIDResult", NewValue = value, OldValue = _getTblDokumentisFortblDokumentIDResult };
                    _getTblDokumentisFortblDokumentIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Bssr.Models.Bssr4.TblKnizenjeM _tblknizenjem;
        protected Bssr.Models.Bssr4.TblKnizenjeM tblknizenjem
        {
            get
            {
                return _tblknizenjem;
            }
            set
            {
                if (!object.Equals(_tblknizenjem, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "tblknizenjem", NewValue = value, OldValue = _tblknizenjem };
                    _tblknizenjem = value;
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
            var bssr4GetTblSmetkasResult = await Bssr4.GetTblSmetkas();
            getTblSmetkasFortblSmetkaIDResult = bssr4GetTblSmetkasResult;

            var bssr4GetTblFakturasResult = await Bssr4.GetTblFakturas();
            getTblFakturasFortblFakturaIDResult = bssr4GetTblFakturasResult;

            var bssr4GetTblPriemsResult = await Bssr4.GetTblPriems();
            getTblPriemsFortblPriemIDResult = bssr4GetTblPriemsResult;

            var bssr4GetTblDokumentisResult = await Bssr4.GetTblDokumentis();
            getTblDokumentisFortblDokumentIDResult = bssr4GetTblDokumentisResult;

            tblknizenjem = new Bssr.Models.Bssr4.TblKnizenjeM(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Bssr.Models.Bssr4.TblKnizenjeM args)
        {
            try
            {
                var bssr4CreateTblKnizenjeMResult = await Bssr4.CreateTblKnizenjeM(tblknizenjem);
                DialogService.Close(tblknizenjem);
            }
            catch (System.Exception bssr4CreateTblKnizenjeMException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblKnizenjeM!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
