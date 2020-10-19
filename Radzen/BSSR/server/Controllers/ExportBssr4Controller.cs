using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bssr.Data;

namespace Bssr
{
    public partial class ExportBssr4Controller : ExportController
    {
        private readonly Bssr4Context context;

        public ExportBssr4Controller(Bssr4Context context)
        {
            this.context = context;
        }
        [HttpGet("/export/Bssr4/changelogs/csv")]
        [HttpGet("/export/Bssr4/changelogs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportChangelogsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Changelogs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/changelogs/excel")]
        [HttpGet("/export/Bssr4/changelogs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportChangelogsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Changelogs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/dbversions/csv")]
        [HttpGet("/export/Bssr4/dbversions/csv(fileName='{fileName}')")]
        public FileStreamResult ExportDbVersionsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.DbVersions, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/dbversions/excel")]
        [HttpGet("/export/Bssr4/dbversions/excel(fileName='{fileName}')")]
        public FileStreamResult ExportDbVersionsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.DbVersions, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/mats/csv")]
        [HttpGet("/export/Bssr4/mats/csv(fileName='{fileName}')")]
        public FileStreamResult ExportMatsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Mats, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/mats/excel")]
        [HttpGet("/export/Bssr4/mats/excel(fileName='{fileName}')")]
        public FileStreamResult ExportMatsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Mats, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/matkujnas/csv")]
        [HttpGet("/export/Bssr4/matkujnas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportMatKujnasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.MatKujnas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/matkujnas/excel")]
        [HttpGet("/export/Bssr4/matkujnas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportMatKujnasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.MatKujnas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblakcijanaartikals/csv")]
        [HttpGet("/export/Bssr4/tblakcijanaartikals/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblAkcijaNaArtikalsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblAkcijaNaArtikals, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblakcijanaartikals/excel")]
        [HttpGet("/export/Bssr4/tblakcijanaartikals/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblAkcijaNaArtikalsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblAkcijaNaArtikals, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblartikals/csv")]
        [HttpGet("/export/Bssr4/tblartikals/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblArtikalsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblArtikals, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblartikals/excel")]
        [HttpGet("/export/Bssr4/tblartikals/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblArtikalsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblArtikals, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblartikalnotuseds/csv")]
        [HttpGet("/export/Bssr4/tblartikalnotuseds/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblArtikalNotUsedsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblArtikalNotUseds, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblartikalnotuseds/excel")]
        [HttpGet("/export/Bssr4/tblartikalnotuseds/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblArtikalNotUsedsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblArtikalNotUseds, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblbankis/csv")]
        [HttpGet("/export/Bssr4/tblbankis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblBankisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblBankis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblbankis/excel")]
        [HttpGet("/export/Bssr4/tblbankis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblBankisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblBankis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblconfigs/csv")]
        [HttpGet("/export/Bssr4/tblconfigs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblConfigsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblConfigs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblconfigs/excel")]
        [HttpGet("/export/Bssr4/tblconfigs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblConfigsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblConfigs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblddvstavkas/csv")]
        [HttpGet("/export/Bssr4/tblddvstavkas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblDdvStavkasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblDdvStavkas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblddvstavkas/excel")]
        [HttpGet("/export/Bssr4/tblddvstavkas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblDdvStavkasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblDdvStavkas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbldokumentstavkis/csv")]
        [HttpGet("/export/Bssr4/tbldokumentstavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblDokumentStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblDokumentStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbldokumentstavkis/excel")]
        [HttpGet("/export/Bssr4/tbldokumentstavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblDokumentStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblDokumentStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbldokumentis/csv")]
        [HttpGet("/export/Bssr4/tbldokumentis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblDokumentisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblDokumentis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbldokumentis/excel")]
        [HttpGet("/export/Bssr4/tbldokumentis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblDokumentisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblDokumentis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbledinecnimerkis/csv")]
        [HttpGet("/export/Bssr4/tbledinecnimerkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblEdinecniMerkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblEdinecniMerkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbledinecnimerkis/excel")]
        [HttpGet("/export/Bssr4/tbledinecnimerkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblEdinecniMerkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblEdinecniMerkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblelektronskopracanjes/csv")]
        [HttpGet("/export/Bssr4/tblelektronskopracanjes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblElektronskoPracanjesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblElektronskoPracanjes, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblelektronskopracanjes/excel")]
        [HttpGet("/export/Bssr4/tblelektronskopracanjes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblElektronskoPracanjesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblElektronskoPracanjes, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblfakturas/csv")]
        [HttpGet("/export/Bssr4/tblfakturas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblFakturasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblFakturas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblfakturas/excel")]
        [HttpGet("/export/Bssr4/tblfakturas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblFakturasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblFakturas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblfakturastavkis/csv")]
        [HttpGet("/export/Bssr4/tblfakturastavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblFakturaStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblFakturaStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblfakturastavkis/excel")]
        [HttpGet("/export/Bssr4/tblfakturastavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblFakturaStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblFakturaStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblfirmas/csv")]
        [HttpGet("/export/Bssr4/tblfirmas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblFirmasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblFirmas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblfirmas/excel")]
        [HttpGet("/export/Bssr4/tblfirmas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblFirmasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblFirmas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblfiskalnismetkis/csv")]
        [HttpGet("/export/Bssr4/tblfiskalnismetkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblFiskalniSmetkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblFiskalniSmetkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblfiskalnismetkis/excel")]
        [HttpGet("/export/Bssr4/tblfiskalnismetkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblFiskalniSmetkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblFiskalniSmetkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblgrupanaartiklis/csv")]
        [HttpGet("/export/Bssr4/tblgrupanaartiklis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblGrupaNaArtiklisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblGrupaNaArtiklis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblgrupanaartiklis/excel")]
        [HttpGet("/export/Bssr4/tblgrupanaartiklis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblGrupaNaArtiklisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblGrupaNaArtiklis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblizvodis/csv")]
        [HttpGet("/export/Bssr4/tblizvodis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblIzvodisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblIzvodis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblizvodis/excel")]
        [HttpGet("/export/Bssr4/tblizvodis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblIzvodisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblIzvodis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblizvodistavkis/csv")]
        [HttpGet("/export/Bssr4/tblizvodistavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblIzvodiStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblIzvodiStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblizvodistavkis/excel")]
        [HttpGet("/export/Bssr4/tblizvodistavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblIzvodiStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblIzvodiStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblknizenjems/csv")]
        [HttpGet("/export/Bssr4/tblknizenjems/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblKnizenjeMsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblKnizenjeMs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblknizenjems/excel")]
        [HttpGet("/export/Bssr4/tblknizenjems/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblKnizenjeMsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblKnizenjeMs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblkursnalista/csv")]
        [HttpGet("/export/Bssr4/tblkursnalista/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblKursnaListaToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblKursnaLista, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblkursnalista/excel")]
        [HttpGet("/export/Bssr4/tblkursnalista/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblKursnaListaToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblKursnaLista, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbllogs/csv")]
        [HttpGet("/export/Bssr4/tbllogs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblLogsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblLogs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbllogs/excel")]
        [HttpGet("/export/Bssr4/tbllogs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblLogsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblLogs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnalogs/csv")]
        [HttpGet("/export/Bssr4/tblnalogs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNalogs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnalogs/excel")]
        [HttpGet("/export/Bssr4/tblnalogs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNalogs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnalogizmeneta/csv")]
        [HttpGet("/export/Bssr4/tblnalogizmeneta/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogIzmenetaToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNalogIzmeneta, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnalogizmeneta/excel")]
        [HttpGet("/export/Bssr4/tblnalogizmeneta/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogIzmenetaToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNalogIzmeneta, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnalogstavkis/csv")]
        [HttpGet("/export/Bssr4/tblnalogstavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNalogStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnalogstavkis/excel")]
        [HttpGet("/export/Bssr4/tblnalogstavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNalogStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnalogstavkiizmeneta/csv")]
        [HttpGet("/export/Bssr4/tblnalogstavkiizmeneta/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogStavkiIzmenetaToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNalogStavkiIzmeneta, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnalogstavkiizmeneta/excel")]
        [HttpGet("/export/Bssr4/tblnalogstavkiizmeneta/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNalogStavkiIzmenetaToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNalogStavkiIzmeneta, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnarackis/csv")]
        [HttpGet("/export/Bssr4/tblnarackis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNarackisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNarackis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnarackis/excel")]
        [HttpGet("/export/Bssr4/tblnarackis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNarackisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNarackis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnetworkpcs/csv")]
        [HttpGet("/export/Bssr4/tblnetworkpcs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNetworkPcsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNetworkPcs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnetworkpcs/excel")]
        [HttpGet("/export/Bssr4/tblnetworkpcs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNetworkPcsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNetworkPcs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnetworkpclogs/csv")]
        [HttpGet("/export/Bssr4/tblnetworkpclogs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNetworkPclogsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNetworkPclogs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnetworkpclogs/excel")]
        [HttpGet("/export/Bssr4/tblnetworkpclogs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNetworkPclogsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNetworkPclogs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnormativs/csv")]
        [HttpGet("/export/Bssr4/tblnormativs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNormativsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNormativs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnormativs/excel")]
        [HttpGet("/export/Bssr4/tblnormativs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNormativsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNormativs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblnormativstavkis/csv")]
        [HttpGet("/export/Bssr4/tblnormativstavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblNormativStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblNormativStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblnormativstavkis/excel")]
        [HttpGet("/export/Bssr4/tblnormativstavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblNormativStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblNormativStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblobjektis/csv")]
        [HttpGet("/export/Bssr4/tblobjektis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblObjektisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblObjektis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblobjektis/excel")]
        [HttpGet("/export/Bssr4/tblobjektis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblObjektisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblObjektis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblpartneris/csv")]
        [HttpGet("/export/Bssr4/tblpartneris/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPartnerisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPartneris, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblpartneris/excel")]
        [HttpGet("/export/Bssr4/tblpartneris/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPartnerisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPartneris, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblpodgrupaids/csv")]
        [HttpGet("/export/Bssr4/tblpodgrupaids/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPodgrupaIdsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPodgrupaIds, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblpodgrupaids/excel")]
        [HttpGet("/export/Bssr4/tblpodgrupaids/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPodgrupaIdsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPodgrupaIds, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblpresmetkovniedinicis/csv")]
        [HttpGet("/export/Bssr4/tblpresmetkovniedinicis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPresmetkovniEdinicisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPresmetkovniEdinicis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblpresmetkovniedinicis/excel")]
        [HttpGet("/export/Bssr4/tblpresmetkovniedinicis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPresmetkovniEdinicisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPresmetkovniEdinicis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblprevodis/csv")]
        [HttpGet("/export/Bssr4/tblprevodis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPrevodisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPrevodis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblprevodis/excel")]
        [HttpGet("/export/Bssr4/tblprevodis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPrevodisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPrevodis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblpriems/csv")]
        [HttpGet("/export/Bssr4/tblpriems/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPriemsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPriems, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblpriems/excel")]
        [HttpGet("/export/Bssr4/tblpriems/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPriemsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPriems, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblpriemstavkis/csv")]
        [HttpGet("/export/Bssr4/tblpriemstavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblPriemStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblPriemStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblpriemstavkis/excel")]
        [HttpGet("/export/Bssr4/tblpriemstavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblPriemStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblPriemStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblsesijas/csv")]
        [HttpGet("/export/Bssr4/tblsesijas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblSesijasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblSesijas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblsesijas/excel")]
        [HttpGet("/export/Bssr4/tblsesijas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblSesijasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblSesijas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblsmetkas/csv")]
        [HttpGet("/export/Bssr4/tblsmetkas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblSmetkas, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblsmetkas/excel")]
        [HttpGet("/export/Bssr4/tblsmetkas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblSmetkas, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblsmetkaizmeneta/csv")]
        [HttpGet("/export/Bssr4/tblsmetkaizmeneta/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaIzmenetaToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblSmetkaIzmeneta, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblsmetkaizmeneta/excel")]
        [HttpGet("/export/Bssr4/tblsmetkaizmeneta/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaIzmenetaToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblSmetkaIzmeneta, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblsmetkastavkis/csv")]
        [HttpGet("/export/Bssr4/tblsmetkastavkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaStavkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblSmetkaStavkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblsmetkastavkis/excel")]
        [HttpGet("/export/Bssr4/tblsmetkastavkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaStavkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblSmetkaStavkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblsmetkastavkiizmeneta/csv")]
        [HttpGet("/export/Bssr4/tblsmetkastavkiizmeneta/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaStavkiIzmenetaToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblSmetkaStavkiIzmeneta, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblsmetkastavkiizmeneta/excel")]
        [HttpGet("/export/Bssr4/tblsmetkastavkiizmeneta/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblSmetkaStavkiIzmenetaToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblSmetkaStavkiIzmeneta, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbltipnadokuments/csv")]
        [HttpGet("/export/Bssr4/tbltipnadokuments/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblTipNaDokumentsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblTipNaDokuments, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbltipnadokuments/excel")]
        [HttpGet("/export/Bssr4/tbltipnadokuments/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblTipNaDokumentsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblTipNaDokuments, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblusers/csv")]
        [HttpGet("/export/Bssr4/tblusers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblUsersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblUsers, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblusers/excel")]
        [HttpGet("/export/Bssr4/tblusers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblUsersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblUsers, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tbluserconfigs/csv")]
        [HttpGet("/export/Bssr4/tbluserconfigs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblUserConfigsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblUserConfigs, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tbluserconfigs/excel")]
        [HttpGet("/export/Bssr4/tbluserconfigs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblUserConfigsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblUserConfigs, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblvalutis/csv")]
        [HttpGet("/export/Bssr4/tblvalutis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblValutisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblValutis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblvalutis/excel")]
        [HttpGet("/export/Bssr4/tblvalutis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblValutisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblValutis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblzabeleshkis/csv")]
        [HttpGet("/export/Bssr4/tblzabeleshkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblZabeleshkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblZabeleshkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblzabeleshkis/excel")]
        [HttpGet("/export/Bssr4/tblzabeleshkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblZabeleshkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblZabeleshkis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblzalihanaartiklis/csv")]
        [HttpGet("/export/Bssr4/tblzalihanaartiklis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblZalihaNaArtiklisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblZalihaNaArtiklis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblzalihanaartiklis/excel")]
        [HttpGet("/export/Bssr4/tblzalihanaartiklis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblZalihaNaArtiklisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblZalihaNaArtiklis, Request.Query), fileName);
        }
        [HttpGet("/export/Bssr4/tblzirosmetkis/csv")]
        [HttpGet("/export/Bssr4/tblzirosmetkis/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTblZiroSmetkisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TblZiroSmetkis, Request.Query), fileName);
        }

        [HttpGet("/export/Bssr4/tblzirosmetkis/excel")]
        [HttpGet("/export/Bssr4/tblzirosmetkis/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTblZiroSmetkisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TblZiroSmetkis, Request.Query), fileName);
        }
    }
}
