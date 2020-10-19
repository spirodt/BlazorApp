using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Bssr.Data;

namespace Bssr
{
    public partial class Bssr4Service
    {
        private readonly Bssr4Context context;
        private readonly NavigationManager navigationManager;

        public Bssr4Service(Bssr4Context context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportChangelogsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/changelogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/changelogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportChangelogsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/changelogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/changelogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnChangelogsRead(ref IQueryable<Models.Bssr4.Changelog> items);

        public async Task<IQueryable<Models.Bssr4.Changelog>> GetChangelogs(Query query = null)
        {
            var items = context.Changelogs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnChangelogsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnChangelogCreated(Models.Bssr4.Changelog item);
        partial void OnAfterChangelogCreated(Models.Bssr4.Changelog item);

        public async Task<Models.Bssr4.Changelog> CreateChangelog(Models.Bssr4.Changelog changelog)
        {
            OnChangelogCreated(changelog);

            context.Changelogs.Add(changelog);
            context.SaveChanges();

            OnAfterChangelogCreated(changelog);

            return changelog;
        }
        public async Task ExportDbVersionsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/dbversions/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/dbversions/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportDbVersionsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/dbversions/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/dbversions/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnDbVersionsRead(ref IQueryable<Models.Bssr4.DbVersion> items);

        public async Task<IQueryable<Models.Bssr4.DbVersion>> GetDbVersions(Query query = null)
        {
            var items = context.DbVersions.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnDbVersionsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnDbVersionCreated(Models.Bssr4.DbVersion item);
        partial void OnAfterDbVersionCreated(Models.Bssr4.DbVersion item);

        public async Task<Models.Bssr4.DbVersion> CreateDbVersion(Models.Bssr4.DbVersion dbVersion)
        {
            OnDbVersionCreated(dbVersion);

            context.DbVersions.Add(dbVersion);
            context.SaveChanges();

            OnAfterDbVersionCreated(dbVersion);

            return dbVersion;
        }
        public async Task ExportMatsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/mats/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/mats/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportMatsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/mats/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/mats/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnMatsRead(ref IQueryable<Models.Bssr4.Mat> items);

        public async Task<IQueryable<Models.Bssr4.Mat>> GetMats(Query query = null)
        {
            var items = context.Mats.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnMatsRead(ref items);

            return await Task.FromResult(items);
        }
        public async Task ExportMatKujnasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/matkujnas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/matkujnas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportMatKujnasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/matkujnas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/matkujnas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnMatKujnasRead(ref IQueryable<Models.Bssr4.MatKujna> items);

        public async Task<IQueryable<Models.Bssr4.MatKujna>> GetMatKujnas(Query query = null)
        {
            var items = context.MatKujnas.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnMatKujnasRead(ref items);

            return await Task.FromResult(items);
        }
        public async Task ExportTblAkcijaNaArtikalsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblakcijanaartikals/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblakcijanaartikals/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblAkcijaNaArtikalsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblakcijanaartikals/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblakcijanaartikals/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblAkcijaNaArtikalsRead(ref IQueryable<Models.Bssr4.TblAkcijaNaArtikal> items);

        public async Task<IQueryable<Models.Bssr4.TblAkcijaNaArtikal>> GetTblAkcijaNaArtikals(Query query = null)
        {
            var items = context.TblAkcijaNaArtikals.AsQueryable();

            items = items.Include(i => i.TblArtikal);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblAkcijaNaArtikalsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblAkcijaNaArtikalCreated(Models.Bssr4.TblAkcijaNaArtikal item);
        partial void OnAfterTblAkcijaNaArtikalCreated(Models.Bssr4.TblAkcijaNaArtikal item);

        public async Task<Models.Bssr4.TblAkcijaNaArtikal> CreateTblAkcijaNaArtikal(Models.Bssr4.TblAkcijaNaArtikal tblAkcijaNaArtikal)
        {
            OnTblAkcijaNaArtikalCreated(tblAkcijaNaArtikal);

            context.TblAkcijaNaArtikals.Add(tblAkcijaNaArtikal);
            context.SaveChanges();

            OnAfterTblAkcijaNaArtikalCreated(tblAkcijaNaArtikal);

            return tblAkcijaNaArtikal;
        }
        public async Task ExportTblArtikalsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblartikals/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblartikals/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblArtikalsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblartikals/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblartikals/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblArtikalsRead(ref IQueryable<Models.Bssr4.TblArtikal> items);

        public async Task<IQueryable<Models.Bssr4.TblArtikal>> GetTblArtikals(Query query = null)
        {
            var items = context.TblArtikals.AsQueryable();

            items = items.Include(i => i.TblDdvStavka);

            items = items.Include(i => i.TblPodgrupaId);

            items = items.Include(i => i.TblEdinecniMerki);

            items = items.Include(i => i.TblFirma);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblArtikalsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblArtikalCreated(Models.Bssr4.TblArtikal item);
        partial void OnAfterTblArtikalCreated(Models.Bssr4.TblArtikal item);

        public async Task<Models.Bssr4.TblArtikal> CreateTblArtikal(Models.Bssr4.TblArtikal tblArtikal)
        {
            OnTblArtikalCreated(tblArtikal);

            context.TblArtikals.Add(tblArtikal);
            context.SaveChanges();

            OnAfterTblArtikalCreated(tblArtikal);

            return tblArtikal;
        }
        public async Task ExportTblArtikalNotUsedsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblartikalnotuseds/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblartikalnotuseds/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblArtikalNotUsedsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblartikalnotuseds/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblartikalnotuseds/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblArtikalNotUsedsRead(ref IQueryable<Models.Bssr4.TblArtikalNotUsed> items);

        public async Task<IQueryable<Models.Bssr4.TblArtikalNotUsed>> GetTblArtikalNotUseds(Query query = null)
        {
            var items = context.TblArtikalNotUseds.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblArtikalNotUsedsRead(ref items);

            return await Task.FromResult(items);
        }
        public async Task ExportTblBankisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblbankis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblbankis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblBankisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblbankis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblbankis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblBankisRead(ref IQueryable<Models.Bssr4.TblBanki> items);

        public async Task<IQueryable<Models.Bssr4.TblBanki>> GetTblBankis(Query query = null)
        {
            var items = context.TblBankis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblBankisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblBankiCreated(Models.Bssr4.TblBanki item);
        partial void OnAfterTblBankiCreated(Models.Bssr4.TblBanki item);

        public async Task<Models.Bssr4.TblBanki> CreateTblBanki(Models.Bssr4.TblBanki tblBanki)
        {
            OnTblBankiCreated(tblBanki);

            context.TblBankis.Add(tblBanki);
            context.SaveChanges();

            OnAfterTblBankiCreated(tblBanki);

            return tblBanki;
        }
        public async Task ExportTblConfigsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblconfigs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblconfigs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblConfigsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblconfigs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblconfigs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblConfigsRead(ref IQueryable<Models.Bssr4.TblConfig> items);

        public async Task<IQueryable<Models.Bssr4.TblConfig>> GetTblConfigs(Query query = null)
        {
            var items = context.TblConfigs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblConfigsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblConfigCreated(Models.Bssr4.TblConfig item);
        partial void OnAfterTblConfigCreated(Models.Bssr4.TblConfig item);

        public async Task<Models.Bssr4.TblConfig> CreateTblConfig(Models.Bssr4.TblConfig tblConfig)
        {
            OnTblConfigCreated(tblConfig);

            context.TblConfigs.Add(tblConfig);
            context.SaveChanges();

            OnAfterTblConfigCreated(tblConfig);

            return tblConfig;
        }
        public async Task ExportTblDdvStavkasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblddvstavkas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblddvstavkas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblDdvStavkasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblddvstavkas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblddvstavkas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblDdvStavkasRead(ref IQueryable<Models.Bssr4.TblDdvStavka> items);

        public async Task<IQueryable<Models.Bssr4.TblDdvStavka>> GetTblDdvStavkas(Query query = null)
        {
            var items = context.TblDdvStavkas.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblDdvStavkasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblDdvStavkaCreated(Models.Bssr4.TblDdvStavka item);
        partial void OnAfterTblDdvStavkaCreated(Models.Bssr4.TblDdvStavka item);

        public async Task<Models.Bssr4.TblDdvStavka> CreateTblDdvStavka(Models.Bssr4.TblDdvStavka tblDdvStavka)
        {
            OnTblDdvStavkaCreated(tblDdvStavka);

            context.TblDdvStavkas.Add(tblDdvStavka);
            context.SaveChanges();

            OnAfterTblDdvStavkaCreated(tblDdvStavka);

            return tblDdvStavka;
        }
        public async Task ExportTblDokumentStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbldokumentstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbldokumentstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblDokumentStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbldokumentstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbldokumentstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblDokumentStavkisRead(ref IQueryable<Models.Bssr4.TblDokumentStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblDokumentStavki>> GetTblDokumentStavkis(Query query = null)
        {
            var items = context.TblDokumentStavkis.AsQueryable();

            items = items.Include(i => i.TblDokumenti);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblDokumentStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblDokumentStavkiCreated(Models.Bssr4.TblDokumentStavki item);
        partial void OnAfterTblDokumentStavkiCreated(Models.Bssr4.TblDokumentStavki item);

        public async Task<Models.Bssr4.TblDokumentStavki> CreateTblDokumentStavki(Models.Bssr4.TblDokumentStavki tblDokumentStavki)
        {
            OnTblDokumentStavkiCreated(tblDokumentStavki);

            context.TblDokumentStavkis.Add(tblDokumentStavki);
            context.SaveChanges();

            OnAfterTblDokumentStavkiCreated(tblDokumentStavki);

            return tblDokumentStavki;
        }
        public async Task ExportTblDokumentisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbldokumentis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbldokumentis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblDokumentisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbldokumentis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbldokumentis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblDokumentisRead(ref IQueryable<Models.Bssr4.TblDokumenti> items);

        public async Task<IQueryable<Models.Bssr4.TblDokumenti>> GetTblDokumentis(Query query = null)
        {
            var items = context.TblDokumentis.AsQueryable();

            items = items.Include(i => i.TblTipNaDokument);

            items = items.Include(i => i.TblPartneri);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblDokumentisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblDokumentiCreated(Models.Bssr4.TblDokumenti item);
        partial void OnAfterTblDokumentiCreated(Models.Bssr4.TblDokumenti item);

        public async Task<Models.Bssr4.TblDokumenti> CreateTblDokumenti(Models.Bssr4.TblDokumenti tblDokumenti)
        {
            OnTblDokumentiCreated(tblDokumenti);

            context.TblDokumentis.Add(tblDokumenti);
            context.SaveChanges();

            OnAfterTblDokumentiCreated(tblDokumenti);

            return tblDokumenti;
        }
        public async Task ExportTblEdinecniMerkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbledinecnimerkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbledinecnimerkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblEdinecniMerkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbledinecnimerkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbledinecnimerkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblEdinecniMerkisRead(ref IQueryable<Models.Bssr4.TblEdinecniMerki> items);

        public async Task<IQueryable<Models.Bssr4.TblEdinecniMerki>> GetTblEdinecniMerkis(Query query = null)
        {
            var items = context.TblEdinecniMerkis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblEdinecniMerkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblEdinecniMerkiCreated(Models.Bssr4.TblEdinecniMerki item);
        partial void OnAfterTblEdinecniMerkiCreated(Models.Bssr4.TblEdinecniMerki item);

        public async Task<Models.Bssr4.TblEdinecniMerki> CreateTblEdinecniMerki(Models.Bssr4.TblEdinecniMerki tblEdinecniMerki)
        {
            OnTblEdinecniMerkiCreated(tblEdinecniMerki);

            context.TblEdinecniMerkis.Add(tblEdinecniMerki);
            context.SaveChanges();

            OnAfterTblEdinecniMerkiCreated(tblEdinecniMerki);

            return tblEdinecniMerki;
        }
        public async Task ExportTblElektronskoPracanjesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblelektronskopracanjes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblelektronskopracanjes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblElektronskoPracanjesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblelektronskopracanjes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblelektronskopracanjes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblElektronskoPracanjesRead(ref IQueryable<Models.Bssr4.TblElektronskoPracanje> items);

        public async Task<IQueryable<Models.Bssr4.TblElektronskoPracanje>> GetTblElektronskoPracanjes(Query query = null)
        {
            var items = context.TblElektronskoPracanjes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblElektronskoPracanjesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblElektronskoPracanjeCreated(Models.Bssr4.TblElektronskoPracanje item);
        partial void OnAfterTblElektronskoPracanjeCreated(Models.Bssr4.TblElektronskoPracanje item);

        public async Task<Models.Bssr4.TblElektronskoPracanje> CreateTblElektronskoPracanje(Models.Bssr4.TblElektronskoPracanje tblElektronskoPracanje)
        {
            OnTblElektronskoPracanjeCreated(tblElektronskoPracanje);

            context.TblElektronskoPracanjes.Add(tblElektronskoPracanje);
            context.SaveChanges();

            OnAfterTblElektronskoPracanjeCreated(tblElektronskoPracanje);

            return tblElektronskoPracanje;
        }
        public async Task ExportTblFakturasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfakturas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfakturas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblFakturasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfakturas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfakturas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblFakturasRead(ref IQueryable<Models.Bssr4.TblFaktura> items);

        public async Task<IQueryable<Models.Bssr4.TblFaktura>> GetTblFakturas(Query query = null)
        {
            var items = context.TblFakturas.AsQueryable();

            items = items.Include(i => i.TblPartneri);

            items = items.Include(i => i.TblZiroSmetki);

            items = items.Include(i => i.TblBanki);

            items = items.Include(i => i.TblUser);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblFakturasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblFakturaCreated(Models.Bssr4.TblFaktura item);
        partial void OnAfterTblFakturaCreated(Models.Bssr4.TblFaktura item);

        public async Task<Models.Bssr4.TblFaktura> CreateTblFaktura(Models.Bssr4.TblFaktura tblFaktura)
        {
            OnTblFakturaCreated(tblFaktura);

            context.TblFakturas.Add(tblFaktura);
            context.SaveChanges();

            OnAfterTblFakturaCreated(tblFaktura);

            return tblFaktura;
        }
        public async Task ExportTblFakturaStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfakturastavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfakturastavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblFakturaStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfakturastavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfakturastavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblFakturaStavkisRead(ref IQueryable<Models.Bssr4.TblFakturaStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblFakturaStavki>> GetTblFakturaStavkis(Query query = null)
        {
            var items = context.TblFakturaStavkis.AsQueryable();

            items = items.Include(i => i.TblFaktura);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblFakturaStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblFakturaStavkiCreated(Models.Bssr4.TblFakturaStavki item);
        partial void OnAfterTblFakturaStavkiCreated(Models.Bssr4.TblFakturaStavki item);

        public async Task<Models.Bssr4.TblFakturaStavki> CreateTblFakturaStavki(Models.Bssr4.TblFakturaStavki tblFakturaStavki)
        {
            OnTblFakturaStavkiCreated(tblFakturaStavki);

            context.TblFakturaStavkis.Add(tblFakturaStavki);
            context.SaveChanges();

            OnAfterTblFakturaStavkiCreated(tblFakturaStavki);

            return tblFakturaStavki;
        }
        public async Task ExportTblFirmasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfirmas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfirmas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblFirmasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfirmas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfirmas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblFirmasRead(ref IQueryable<Models.Bssr4.TblFirma> items);

        public async Task<IQueryable<Models.Bssr4.TblFirma>> GetTblFirmas(Query query = null)
        {
            var items = context.TblFirmas.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblFirmasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblFirmaCreated(Models.Bssr4.TblFirma item);
        partial void OnAfterTblFirmaCreated(Models.Bssr4.TblFirma item);

        public async Task<Models.Bssr4.TblFirma> CreateTblFirma(Models.Bssr4.TblFirma tblFirma)
        {
            OnTblFirmaCreated(tblFirma);

            context.TblFirmas.Add(tblFirma);
            context.SaveChanges();

            OnAfterTblFirmaCreated(tblFirma);

            return tblFirma;
        }
        public async Task ExportTblFiskalniSmetkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfiskalnismetkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfiskalnismetkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblFiskalniSmetkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblfiskalnismetkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblfiskalnismetkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblFiskalniSmetkisRead(ref IQueryable<Models.Bssr4.TblFiskalniSmetki> items);

        public async Task<IQueryable<Models.Bssr4.TblFiskalniSmetki>> GetTblFiskalniSmetkis(Query query = null)
        {
            var items = context.TblFiskalniSmetkis.AsQueryable();

            items = items.Include(i => i.TblSmetka);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblFiskalniSmetkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblFiskalniSmetkiCreated(Models.Bssr4.TblFiskalniSmetki item);
        partial void OnAfterTblFiskalniSmetkiCreated(Models.Bssr4.TblFiskalniSmetki item);

        public async Task<Models.Bssr4.TblFiskalniSmetki> CreateTblFiskalniSmetki(Models.Bssr4.TblFiskalniSmetki tblFiskalniSmetki)
        {
            OnTblFiskalniSmetkiCreated(tblFiskalniSmetki);

            context.TblFiskalniSmetkis.Add(tblFiskalniSmetki);
            context.SaveChanges();

            OnAfterTblFiskalniSmetkiCreated(tblFiskalniSmetki);

            return tblFiskalniSmetki;
        }
        public async Task ExportTblGrupaNaArtiklisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblgrupanaartiklis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblgrupanaartiklis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblGrupaNaArtiklisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblgrupanaartiklis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblgrupanaartiklis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblGrupaNaArtiklisRead(ref IQueryable<Models.Bssr4.TblGrupaNaArtikli> items);

        public async Task<IQueryable<Models.Bssr4.TblGrupaNaArtikli>> GetTblGrupaNaArtiklis(Query query = null)
        {
            var items = context.TblGrupaNaArtiklis.AsQueryable();

            items = items.Include(i => i.TblFirma);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGrupaNaArtiklisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGrupaNaArtikliCreated(Models.Bssr4.TblGrupaNaArtikli item);
        partial void OnAfterTblGrupaNaArtikliCreated(Models.Bssr4.TblGrupaNaArtikli item);

        public async Task<Models.Bssr4.TblGrupaNaArtikli> CreateTblGrupaNaArtikli(Models.Bssr4.TblGrupaNaArtikli tblGrupaNaArtikli)
        {
            OnTblGrupaNaArtikliCreated(tblGrupaNaArtikli);

            context.TblGrupaNaArtiklis.Add(tblGrupaNaArtikli);
            context.SaveChanges();

            OnAfterTblGrupaNaArtikliCreated(tblGrupaNaArtikli);

            return tblGrupaNaArtikli;
        }
        public async Task ExportTblIzvodisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblizvodis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblizvodis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblIzvodisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblizvodis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblizvodis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblIzvodisRead(ref IQueryable<Models.Bssr4.TblIzvodi> items);

        public async Task<IQueryable<Models.Bssr4.TblIzvodi>> GetTblIzvodis(Query query = null)
        {
            var items = context.TblIzvodis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIzvodisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIzvodiCreated(Models.Bssr4.TblIzvodi item);
        partial void OnAfterTblIzvodiCreated(Models.Bssr4.TblIzvodi item);

        public async Task<Models.Bssr4.TblIzvodi> CreateTblIzvodi(Models.Bssr4.TblIzvodi tblIzvodi)
        {
            OnTblIzvodiCreated(tblIzvodi);

            context.TblIzvodis.Add(tblIzvodi);
            context.SaveChanges();

            OnAfterTblIzvodiCreated(tblIzvodi);

            return tblIzvodi;
        }
        public async Task ExportTblIzvodiStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblizvodistavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblizvodistavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblIzvodiStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblizvodistavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblizvodistavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblIzvodiStavkisRead(ref IQueryable<Models.Bssr4.TblIzvodiStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblIzvodiStavki>> GetTblIzvodiStavkis(Query query = null)
        {
            var items = context.TblIzvodiStavkis.AsQueryable();

            items = items.Include(i => i.TblIzvodi);

            items = items.Include(i => i.TblPartneri);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIzvodiStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIzvodiStavkiCreated(Models.Bssr4.TblIzvodiStavki item);
        partial void OnAfterTblIzvodiStavkiCreated(Models.Bssr4.TblIzvodiStavki item);

        public async Task<Models.Bssr4.TblIzvodiStavki> CreateTblIzvodiStavki(Models.Bssr4.TblIzvodiStavki tblIzvodiStavki)
        {
            OnTblIzvodiStavkiCreated(tblIzvodiStavki);

            context.TblIzvodiStavkis.Add(tblIzvodiStavki);
            context.SaveChanges();

            OnAfterTblIzvodiStavkiCreated(tblIzvodiStavki);

            return tblIzvodiStavki;
        }
        public async Task ExportTblKnizenjeMsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblknizenjems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblknizenjems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblKnizenjeMsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblknizenjems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblknizenjems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblKnizenjeMsRead(ref IQueryable<Models.Bssr4.TblKnizenjeM> items);

        public async Task<IQueryable<Models.Bssr4.TblKnizenjeM>> GetTblKnizenjeMs(Query query = null)
        {
            var items = context.TblKnizenjeMs.AsQueryable();

            items = items.Include(i => i.TblSmetka);

            items = items.Include(i => i.TblFaktura);

            items = items.Include(i => i.TblPriem);

            items = items.Include(i => i.TblDokumenti);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblKnizenjeMsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblKnizenjeMCreated(Models.Bssr4.TblKnizenjeM item);
        partial void OnAfterTblKnizenjeMCreated(Models.Bssr4.TblKnizenjeM item);

        public async Task<Models.Bssr4.TblKnizenjeM> CreateTblKnizenjeM(Models.Bssr4.TblKnizenjeM tblKnizenjeM)
        {
            OnTblKnizenjeMCreated(tblKnizenjeM);

            context.TblKnizenjeMs.Add(tblKnizenjeM);
            context.SaveChanges();

            OnAfterTblKnizenjeMCreated(tblKnizenjeM);

            return tblKnizenjeM;
        }
        public async Task ExportTblKursnaListaToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblkursnalista/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblkursnalista/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblKursnaListaToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblkursnalista/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblkursnalista/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblKursnaListaRead(ref IQueryable<Models.Bssr4.TblKursnaListum> items);

        public async Task<IQueryable<Models.Bssr4.TblKursnaListum>> GetTblKursnaLista(Query query = null)
        {
            var items = context.TblKursnaLista.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblKursnaListaRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblKursnaListumCreated(Models.Bssr4.TblKursnaListum item);
        partial void OnAfterTblKursnaListumCreated(Models.Bssr4.TblKursnaListum item);

        public async Task<Models.Bssr4.TblKursnaListum> CreateTblKursnaListum(Models.Bssr4.TblKursnaListum tblKursnaListum)
        {
            OnTblKursnaListumCreated(tblKursnaListum);

            context.TblKursnaLista.Add(tblKursnaListum);
            context.SaveChanges();

            OnAfterTblKursnaListumCreated(tblKursnaListum);

            return tblKursnaListum;
        }
        public async Task ExportTblLogsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbllogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbllogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblLogsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbllogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbllogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblLogsRead(ref IQueryable<Models.Bssr4.TblLog> items);

        public async Task<IQueryable<Models.Bssr4.TblLog>> GetTblLogs(Query query = null)
        {
            var items = context.TblLogs.AsQueryable();

            items = items.Include(i => i.TblSesija);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblLogsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblLogCreated(Models.Bssr4.TblLog item);
        partial void OnAfterTblLogCreated(Models.Bssr4.TblLog item);

        public async Task<Models.Bssr4.TblLog> CreateTblLog(Models.Bssr4.TblLog tblLog)
        {
            OnTblLogCreated(tblLog);

            context.TblLogs.Add(tblLog);
            context.SaveChanges();

            OnAfterTblLogCreated(tblLog);

            return tblLog;
        }
        public async Task ExportTblNalogsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNalogsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNalogsRead(ref IQueryable<Models.Bssr4.TblNalog> items);

        public async Task<IQueryable<Models.Bssr4.TblNalog>> GetTblNalogs(Query query = null)
        {
            var items = context.TblNalogs.AsQueryable();

            items = items.Include(i => i.TblFirma);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNalogsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNalogCreated(Models.Bssr4.TblNalog item);
        partial void OnAfterTblNalogCreated(Models.Bssr4.TblNalog item);

        public async Task<Models.Bssr4.TblNalog> CreateTblNalog(Models.Bssr4.TblNalog tblNalog)
        {
            OnTblNalogCreated(tblNalog);

            context.TblNalogs.Add(tblNalog);
            context.SaveChanges();

            OnAfterTblNalogCreated(tblNalog);

            return tblNalog;
        }
        public async Task ExportTblNalogIzmenetaToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNalogIzmenetaToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNalogIzmenetaRead(ref IQueryable<Models.Bssr4.TblNalogIzmenetum> items);

        public async Task<IQueryable<Models.Bssr4.TblNalogIzmenetum>> GetTblNalogIzmeneta(Query query = null)
        {
            var items = context.TblNalogIzmeneta.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNalogIzmenetaRead(ref items);

            return await Task.FromResult(items);
        }
        public async Task ExportTblNalogStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNalogStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNalogStavkisRead(ref IQueryable<Models.Bssr4.TblNalogStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblNalogStavki>> GetTblNalogStavkis(Query query = null)
        {
            var items = context.TblNalogStavkis.AsQueryable();

            items = items.Include(i => i.TblNalog);

            items = items.Include(i => i.TblNormativ);

            items = items.Include(i => i.TblArtikal);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNalogStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNalogStavkiCreated(Models.Bssr4.TblNalogStavki item);
        partial void OnAfterTblNalogStavkiCreated(Models.Bssr4.TblNalogStavki item);

        public async Task<Models.Bssr4.TblNalogStavki> CreateTblNalogStavki(Models.Bssr4.TblNalogStavki tblNalogStavki)
        {
            OnTblNalogStavkiCreated(tblNalogStavki);

            context.TblNalogStavkis.Add(tblNalogStavki);
            context.SaveChanges();

            OnAfterTblNalogStavkiCreated(tblNalogStavki);

            return tblNalogStavki;
        }
        public async Task ExportTblNalogStavkiIzmenetaToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogstavkiizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogstavkiizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNalogStavkiIzmenetaToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnalogstavkiizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnalogstavkiizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNalogStavkiIzmenetaRead(ref IQueryable<Models.Bssr4.TblNalogStavkiIzmenetum> items);

        public async Task<IQueryable<Models.Bssr4.TblNalogStavkiIzmenetum>> GetTblNalogStavkiIzmeneta(Query query = null)
        {
            var items = context.TblNalogStavkiIzmeneta.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNalogStavkiIzmenetaRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNalogStavkiIzmenetumCreated(Models.Bssr4.TblNalogStavkiIzmenetum item);
        partial void OnAfterTblNalogStavkiIzmenetumCreated(Models.Bssr4.TblNalogStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblNalogStavkiIzmenetum> CreateTblNalogStavkiIzmenetum(Models.Bssr4.TblNalogStavkiIzmenetum tblNalogStavkiIzmenetum)
        {
            OnTblNalogStavkiIzmenetumCreated(tblNalogStavkiIzmenetum);

            context.TblNalogStavkiIzmeneta.Add(tblNalogStavkiIzmenetum);
            context.SaveChanges();

            OnAfterTblNalogStavkiIzmenetumCreated(tblNalogStavkiIzmenetum);

            return tblNalogStavkiIzmenetum;
        }
        public async Task ExportTblNarackisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnarackis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnarackis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNarackisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnarackis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnarackis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNarackisRead(ref IQueryable<Models.Bssr4.TblNaracki> items);

        public async Task<IQueryable<Models.Bssr4.TblNaracki>> GetTblNarackis(Query query = null)
        {
            var items = context.TblNarackis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNarackisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNarackiCreated(Models.Bssr4.TblNaracki item);
        partial void OnAfterTblNarackiCreated(Models.Bssr4.TblNaracki item);

        public async Task<Models.Bssr4.TblNaracki> CreateTblNaracki(Models.Bssr4.TblNaracki tblNaracki)
        {
            OnTblNarackiCreated(tblNaracki);

            context.TblNarackis.Add(tblNaracki);
            context.SaveChanges();

            OnAfterTblNarackiCreated(tblNaracki);

            return tblNaracki;
        }
        public async Task ExportTblNetworkPcsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnetworkpcs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnetworkpcs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNetworkPcsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnetworkpcs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnetworkpcs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNetworkPcsRead(ref IQueryable<Models.Bssr4.TblNetworkPc> items);

        public async Task<IQueryable<Models.Bssr4.TblNetworkPc>> GetTblNetworkPcs(Query query = null)
        {
            var items = context.TblNetworkPcs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNetworkPcsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNetworkPcCreated(Models.Bssr4.TblNetworkPc item);
        partial void OnAfterTblNetworkPcCreated(Models.Bssr4.TblNetworkPc item);

        public async Task<Models.Bssr4.TblNetworkPc> CreateTblNetworkPc(Models.Bssr4.TblNetworkPc tblNetworkPc)
        {
            OnTblNetworkPcCreated(tblNetworkPc);

            context.TblNetworkPcs.Add(tblNetworkPc);
            context.SaveChanges();

            OnAfterTblNetworkPcCreated(tblNetworkPc);

            return tblNetworkPc;
        }
        public async Task ExportTblNetworkPclogsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnetworkpclogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnetworkpclogs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNetworkPclogsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnetworkpclogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnetworkpclogs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNetworkPclogsRead(ref IQueryable<Models.Bssr4.TblNetworkPclog> items);

        public async Task<IQueryable<Models.Bssr4.TblNetworkPclog>> GetTblNetworkPclogs(Query query = null)
        {
            var items = context.TblNetworkPclogs.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNetworkPclogsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNetworkPclogCreated(Models.Bssr4.TblNetworkPclog item);
        partial void OnAfterTblNetworkPclogCreated(Models.Bssr4.TblNetworkPclog item);

        public async Task<Models.Bssr4.TblNetworkPclog> CreateTblNetworkPclog(Models.Bssr4.TblNetworkPclog tblNetworkPclog)
        {
            OnTblNetworkPclogCreated(tblNetworkPclog);

            context.TblNetworkPclogs.Add(tblNetworkPclog);
            context.SaveChanges();

            OnAfterTblNetworkPclogCreated(tblNetworkPclog);

            return tblNetworkPclog;
        }
        public async Task ExportTblNormativsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnormativs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnormativs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNormativsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnormativs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnormativs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNormativsRead(ref IQueryable<Models.Bssr4.TblNormativ> items);

        public async Task<IQueryable<Models.Bssr4.TblNormativ>> GetTblNormativs(Query query = null)
        {
            var items = context.TblNormativs.AsQueryable();

            items = items.Include(i => i.TblFirma);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNormativsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNormativCreated(Models.Bssr4.TblNormativ item);
        partial void OnAfterTblNormativCreated(Models.Bssr4.TblNormativ item);

        public async Task<Models.Bssr4.TblNormativ> CreateTblNormativ(Models.Bssr4.TblNormativ tblNormativ)
        {
            OnTblNormativCreated(tblNormativ);

            context.TblNormativs.Add(tblNormativ);
            context.SaveChanges();

            OnAfterTblNormativCreated(tblNormativ);

            return tblNormativ;
        }
        public async Task ExportTblNormativStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnormativstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnormativstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblNormativStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblnormativstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblnormativstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblNormativStavkisRead(ref IQueryable<Models.Bssr4.TblNormativStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblNormativStavki>> GetTblNormativStavkis(Query query = null)
        {
            var items = context.TblNormativStavkis.AsQueryable();

            items = items.Include(i => i.TblNormativ);

            items = items.Include(i => i.TblArtikal);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblNormativStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblNormativStavkiCreated(Models.Bssr4.TblNormativStavki item);
        partial void OnAfterTblNormativStavkiCreated(Models.Bssr4.TblNormativStavki item);

        public async Task<Models.Bssr4.TblNormativStavki> CreateTblNormativStavki(Models.Bssr4.TblNormativStavki tblNormativStavki)
        {
            OnTblNormativStavkiCreated(tblNormativStavki);

            context.TblNormativStavkis.Add(tblNormativStavki);
            context.SaveChanges();

            OnAfterTblNormativStavkiCreated(tblNormativStavki);

            return tblNormativStavki;
        }
        public async Task ExportTblObjektisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblobjektis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblobjektis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblObjektisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblobjektis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblobjektis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblObjektisRead(ref IQueryable<Models.Bssr4.TblObjekti> items);

        public async Task<IQueryable<Models.Bssr4.TblObjekti>> GetTblObjektis(Query query = null)
        {
            var items = context.TblObjektis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblObjektisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblObjektiCreated(Models.Bssr4.TblObjekti item);
        partial void OnAfterTblObjektiCreated(Models.Bssr4.TblObjekti item);

        public async Task<Models.Bssr4.TblObjekti> CreateTblObjekti(Models.Bssr4.TblObjekti tblObjekti)
        {
            OnTblObjektiCreated(tblObjekti);

            context.TblObjektis.Add(tblObjekti);
            context.SaveChanges();

            OnAfterTblObjektiCreated(tblObjekti);

            return tblObjekti;
        }
        public async Task ExportTblPartnerisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpartneris/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpartneris/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPartnerisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpartneris/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpartneris/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPartnerisRead(ref IQueryable<Models.Bssr4.TblPartneri> items);

        public async Task<IQueryable<Models.Bssr4.TblPartneri>> GetTblPartneris(Query query = null)
        {
            var items = context.TblPartneris.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPartnerisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPartneriCreated(Models.Bssr4.TblPartneri item);
        partial void OnAfterTblPartneriCreated(Models.Bssr4.TblPartneri item);

        public async Task<Models.Bssr4.TblPartneri> CreateTblPartneri(Models.Bssr4.TblPartneri tblPartneri)
        {
            OnTblPartneriCreated(tblPartneri);

            context.TblPartneris.Add(tblPartneri);
            context.SaveChanges();

            OnAfterTblPartneriCreated(tblPartneri);

            return tblPartneri;
        }
        public async Task ExportTblPodgrupaIdsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpodgrupaids/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpodgrupaids/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPodgrupaIdsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpodgrupaids/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpodgrupaids/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPodgrupaIdsRead(ref IQueryable<Models.Bssr4.TblPodgrupaId> items);

        public async Task<IQueryable<Models.Bssr4.TblPodgrupaId>> GetTblPodgrupaIds(Query query = null)
        {
            var items = context.TblPodgrupaIds.AsQueryable();

            items = items.Include(i => i.TblGrupaNaArtikli);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPodgrupaIdsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPodgrupaIdCreated(Models.Bssr4.TblPodgrupaId item);
        partial void OnAfterTblPodgrupaIdCreated(Models.Bssr4.TblPodgrupaId item);

        public async Task<Models.Bssr4.TblPodgrupaId> CreateTblPodgrupaId(Models.Bssr4.TblPodgrupaId tblPodgrupaId)
        {
            OnTblPodgrupaIdCreated(tblPodgrupaId);

            context.TblPodgrupaIds.Add(tblPodgrupaId);
            context.SaveChanges();

            OnAfterTblPodgrupaIdCreated(tblPodgrupaId);

            return tblPodgrupaId;
        }
        public async Task ExportTblPresmetkovniEdinicisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpresmetkovniedinicis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpresmetkovniedinicis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPresmetkovniEdinicisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpresmetkovniedinicis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpresmetkovniedinicis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPresmetkovniEdinicisRead(ref IQueryable<Models.Bssr4.TblPresmetkovniEdinici> items);

        public async Task<IQueryable<Models.Bssr4.TblPresmetkovniEdinici>> GetTblPresmetkovniEdinicis(Query query = null)
        {
            var items = context.TblPresmetkovniEdinicis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPresmetkovniEdinicisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPresmetkovniEdiniciCreated(Models.Bssr4.TblPresmetkovniEdinici item);
        partial void OnAfterTblPresmetkovniEdiniciCreated(Models.Bssr4.TblPresmetkovniEdinici item);

        public async Task<Models.Bssr4.TblPresmetkovniEdinici> CreateTblPresmetkovniEdinici(Models.Bssr4.TblPresmetkovniEdinici tblPresmetkovniEdinici)
        {
            OnTblPresmetkovniEdiniciCreated(tblPresmetkovniEdinici);

            context.TblPresmetkovniEdinicis.Add(tblPresmetkovniEdinici);
            context.SaveChanges();

            OnAfterTblPresmetkovniEdiniciCreated(tblPresmetkovniEdinici);

            return tblPresmetkovniEdinici;
        }
        public async Task ExportTblPrevodisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblprevodis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblprevodis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPrevodisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblprevodis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblprevodis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPrevodisRead(ref IQueryable<Models.Bssr4.TblPrevodi> items);

        public async Task<IQueryable<Models.Bssr4.TblPrevodi>> GetTblPrevodis(Query query = null)
        {
            var items = context.TblPrevodis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPrevodisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPrevodiCreated(Models.Bssr4.TblPrevodi item);
        partial void OnAfterTblPrevodiCreated(Models.Bssr4.TblPrevodi item);

        public async Task<Models.Bssr4.TblPrevodi> CreateTblPrevodi(Models.Bssr4.TblPrevodi tblPrevodi)
        {
            OnTblPrevodiCreated(tblPrevodi);

            context.TblPrevodis.Add(tblPrevodi);
            context.SaveChanges();

            OnAfterTblPrevodiCreated(tblPrevodi);

            return tblPrevodi;
        }
        public async Task ExportTblPriemsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpriems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpriems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPriemsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpriems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpriems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPriemsRead(ref IQueryable<Models.Bssr4.TblPriem> items);

        public async Task<IQueryable<Models.Bssr4.TblPriem>> GetTblPriems(Query query = null)
        {
            var items = context.TblPriems.AsQueryable();

            items = items.Include(i => i.TblPartneri);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPriemsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPriemCreated(Models.Bssr4.TblPriem item);
        partial void OnAfterTblPriemCreated(Models.Bssr4.TblPriem item);

        public async Task<Models.Bssr4.TblPriem> CreateTblPriem(Models.Bssr4.TblPriem tblPriem)
        {
            OnTblPriemCreated(tblPriem);

            context.TblPriems.Add(tblPriem);
            context.SaveChanges();

            OnAfterTblPriemCreated(tblPriem);

            return tblPriem;
        }
        public async Task ExportTblPriemStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpriemstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpriemstavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblPriemStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblpriemstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblpriemstavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblPriemStavkisRead(ref IQueryable<Models.Bssr4.TblPriemStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblPriemStavki>> GetTblPriemStavkis(Query query = null)
        {
            var items = context.TblPriemStavkis.AsQueryable();

            items = items.Include(i => i.TblPriem);

            items = items.Include(i => i.TblArtikal);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPriemStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPriemStavkiCreated(Models.Bssr4.TblPriemStavki item);
        partial void OnAfterTblPriemStavkiCreated(Models.Bssr4.TblPriemStavki item);

        public async Task<Models.Bssr4.TblPriemStavki> CreateTblPriemStavki(Models.Bssr4.TblPriemStavki tblPriemStavki)
        {
            OnTblPriemStavkiCreated(tblPriemStavki);

            context.TblPriemStavkis.Add(tblPriemStavki);
            context.SaveChanges();

            OnAfterTblPriemStavkiCreated(tblPriemStavki);

            return tblPriemStavki;
        }
        public async Task ExportTblSesijasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsesijas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsesijas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblSesijasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsesijas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsesijas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblSesijasRead(ref IQueryable<Models.Bssr4.TblSesija> items);

        public async Task<IQueryable<Models.Bssr4.TblSesija>> GetTblSesijas(Query query = null)
        {
            var items = context.TblSesijas.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSesijasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSesijaCreated(Models.Bssr4.TblSesija item);
        partial void OnAfterTblSesijaCreated(Models.Bssr4.TblSesija item);

        public async Task<Models.Bssr4.TblSesija> CreateTblSesija(Models.Bssr4.TblSesija tblSesija)
        {
            OnTblSesijaCreated(tblSesija);

            context.TblSesijas.Add(tblSesija);
            context.SaveChanges();

            OnAfterTblSesijaCreated(tblSesija);

            return tblSesija;
        }
        public async Task ExportTblSmetkasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblSmetkasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblSmetkasRead(ref IQueryable<Models.Bssr4.TblSmetka> items);

        public async Task<IQueryable<Models.Bssr4.TblSmetka>> GetTblSmetkas(Query query = null)
        {
            var items = context.TblSmetkas.AsQueryable();

            items = items.Include(i => i.TblUser);

            items = items.Include(i => i.TblFirma);

            items = items.Include(i => i.TblObjekti);

            items = items.Include(i => i.TblPartneri);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSmetkasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSmetkaCreated(Models.Bssr4.TblSmetka item);
        partial void OnAfterTblSmetkaCreated(Models.Bssr4.TblSmetka item);

        public async Task<Models.Bssr4.TblSmetka> CreateTblSmetka(Models.Bssr4.TblSmetka tblSmetka)
        {
            OnTblSmetkaCreated(tblSmetka);

            context.TblSmetkas.Add(tblSmetka);
            context.SaveChanges();

            OnAfterTblSmetkaCreated(tblSmetka);

            return tblSmetka;
        }
        public async Task ExportTblSmetkaIzmenetaToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkaizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkaizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblSmetkaIzmenetaToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkaizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkaizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblSmetkaIzmenetaRead(ref IQueryable<Models.Bssr4.TblSmetkaIzmenetum> items);

        public async Task<IQueryable<Models.Bssr4.TblSmetkaIzmenetum>> GetTblSmetkaIzmeneta(Query query = null)
        {
            var items = context.TblSmetkaIzmeneta.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSmetkaIzmenetaRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSmetkaIzmenetumCreated(Models.Bssr4.TblSmetkaIzmenetum item);
        partial void OnAfterTblSmetkaIzmenetumCreated(Models.Bssr4.TblSmetkaIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaIzmenetum> CreateTblSmetkaIzmenetum(Models.Bssr4.TblSmetkaIzmenetum tblSmetkaIzmenetum)
        {
            OnTblSmetkaIzmenetumCreated(tblSmetkaIzmenetum);

            context.TblSmetkaIzmeneta.Add(tblSmetkaIzmenetum);
            context.SaveChanges();

            OnAfterTblSmetkaIzmenetumCreated(tblSmetkaIzmenetum);

            return tblSmetkaIzmenetum;
        }
        public async Task ExportTblSmetkaStavkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkastavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkastavkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblSmetkaStavkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkastavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkastavkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblSmetkaStavkisRead(ref IQueryable<Models.Bssr4.TblSmetkaStavki> items);

        public async Task<IQueryable<Models.Bssr4.TblSmetkaStavki>> GetTblSmetkaStavkis(Query query = null)
        {
            var items = context.TblSmetkaStavkis.AsQueryable();

            items = items.Include(i => i.TblSmetka);

            items = items.Include(i => i.TblNalog);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSmetkaStavkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSmetkaStavkiCreated(Models.Bssr4.TblSmetkaStavki item);
        partial void OnAfterTblSmetkaStavkiCreated(Models.Bssr4.TblSmetkaStavki item);

        public async Task<Models.Bssr4.TblSmetkaStavki> CreateTblSmetkaStavki(Models.Bssr4.TblSmetkaStavki tblSmetkaStavki)
        {
            OnTblSmetkaStavkiCreated(tblSmetkaStavki);

            context.TblSmetkaStavkis.Add(tblSmetkaStavki);
            context.SaveChanges();

            OnAfterTblSmetkaStavkiCreated(tblSmetkaStavki);

            return tblSmetkaStavki;
        }
        public async Task ExportTblSmetkaStavkiIzmenetaToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkastavkiizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkastavkiizmeneta/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblSmetkaStavkiIzmenetaToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblsmetkastavkiizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblsmetkastavkiizmeneta/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblSmetkaStavkiIzmenetaRead(ref IQueryable<Models.Bssr4.TblSmetkaStavkiIzmenetum> items);

        public async Task<IQueryable<Models.Bssr4.TblSmetkaStavkiIzmenetum>> GetTblSmetkaStavkiIzmeneta(Query query = null)
        {
            var items = context.TblSmetkaStavkiIzmeneta.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSmetkaStavkiIzmenetaRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSmetkaStavkiIzmenetumCreated(Models.Bssr4.TblSmetkaStavkiIzmenetum item);
        partial void OnAfterTblSmetkaStavkiIzmenetumCreated(Models.Bssr4.TblSmetkaStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaStavkiIzmenetum> CreateTblSmetkaStavkiIzmenetum(Models.Bssr4.TblSmetkaStavkiIzmenetum tblSmetkaStavkiIzmenetum)
        {
            OnTblSmetkaStavkiIzmenetumCreated(tblSmetkaStavkiIzmenetum);

            context.TblSmetkaStavkiIzmeneta.Add(tblSmetkaStavkiIzmenetum);
            context.SaveChanges();

            OnAfterTblSmetkaStavkiIzmenetumCreated(tblSmetkaStavkiIzmenetum);

            return tblSmetkaStavkiIzmenetum;
        }
        public async Task ExportTblTipNaDokumentsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbltipnadokuments/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbltipnadokuments/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblTipNaDokumentsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbltipnadokuments/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbltipnadokuments/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblTipNaDokumentsRead(ref IQueryable<Models.Bssr4.TblTipNaDokument> items);

        public async Task<IQueryable<Models.Bssr4.TblTipNaDokument>> GetTblTipNaDokuments(Query query = null)
        {
            var items = context.TblTipNaDokuments.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblTipNaDokumentsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblTipNaDokumentCreated(Models.Bssr4.TblTipNaDokument item);
        partial void OnAfterTblTipNaDokumentCreated(Models.Bssr4.TblTipNaDokument item);

        public async Task<Models.Bssr4.TblTipNaDokument> CreateTblTipNaDokument(Models.Bssr4.TblTipNaDokument tblTipNaDokument)
        {
            OnTblTipNaDokumentCreated(tblTipNaDokument);

            context.TblTipNaDokuments.Add(tblTipNaDokument);
            context.SaveChanges();

            OnAfterTblTipNaDokumentCreated(tblTipNaDokument);

            return tblTipNaDokument;
        }
        public async Task ExportTblUsersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblusers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblusers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblUsersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblusers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblusers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblUsersRead(ref IQueryable<Models.Bssr4.TblUser> items);

        public async Task<IQueryable<Models.Bssr4.TblUser>> GetTblUsers(Query query = null)
        {
            var items = context.TblUsers.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblUsersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblUserCreated(Models.Bssr4.TblUser item);
        partial void OnAfterTblUserCreated(Models.Bssr4.TblUser item);

        public async Task<Models.Bssr4.TblUser> CreateTblUser(Models.Bssr4.TblUser tblUser)
        {
            OnTblUserCreated(tblUser);

            context.TblUsers.Add(tblUser);
            context.SaveChanges();

            OnAfterTblUserCreated(tblUser);

            return tblUser;
        }
        public async Task ExportTblUserConfigsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbluserconfigs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbluserconfigs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblUserConfigsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tbluserconfigs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tbluserconfigs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblUserConfigsRead(ref IQueryable<Models.Bssr4.TblUserConfig> items);

        public async Task<IQueryable<Models.Bssr4.TblUserConfig>> GetTblUserConfigs(Query query = null)
        {
            var items = context.TblUserConfigs.AsQueryable();

            items = items.Include(i => i.TblUser);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblUserConfigsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblUserConfigCreated(Models.Bssr4.TblUserConfig item);
        partial void OnAfterTblUserConfigCreated(Models.Bssr4.TblUserConfig item);

        public async Task<Models.Bssr4.TblUserConfig> CreateTblUserConfig(Models.Bssr4.TblUserConfig tblUserConfig)
        {
            OnTblUserConfigCreated(tblUserConfig);

            context.TblUserConfigs.Add(tblUserConfig);
            context.SaveChanges();

            OnAfterTblUserConfigCreated(tblUserConfig);

            return tblUserConfig;
        }
        public async Task ExportTblValutisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblvalutis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblvalutis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblValutisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblvalutis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblvalutis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblValutisRead(ref IQueryable<Models.Bssr4.TblValuti> items);

        public async Task<IQueryable<Models.Bssr4.TblValuti>> GetTblValutis(Query query = null)
        {
            var items = context.TblValutis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblValutisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblValutiCreated(Models.Bssr4.TblValuti item);
        partial void OnAfterTblValutiCreated(Models.Bssr4.TblValuti item);

        public async Task<Models.Bssr4.TblValuti> CreateTblValuti(Models.Bssr4.TblValuti tblValuti)
        {
            OnTblValutiCreated(tblValuti);

            context.TblValutis.Add(tblValuti);
            context.SaveChanges();

            OnAfterTblValutiCreated(tblValuti);

            return tblValuti;
        }
        public async Task ExportTblZabeleshkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzabeleshkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzabeleshkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblZabeleshkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzabeleshkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzabeleshkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblZabeleshkisRead(ref IQueryable<Models.Bssr4.TblZabeleshki> items);

        public async Task<IQueryable<Models.Bssr4.TblZabeleshki>> GetTblZabeleshkis(Query query = null)
        {
            var items = context.TblZabeleshkis.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblZabeleshkisRead(ref items);

            return await Task.FromResult(items);
        }
        public async Task ExportTblZalihaNaArtiklisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzalihanaartiklis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzalihanaartiklis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblZalihaNaArtiklisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzalihanaartiklis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzalihanaartiklis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblZalihaNaArtiklisRead(ref IQueryable<Models.Bssr4.TblZalihaNaArtikli> items);

        public async Task<IQueryable<Models.Bssr4.TblZalihaNaArtikli>> GetTblZalihaNaArtiklis(Query query = null)
        {
            var items = context.TblZalihaNaArtiklis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblZalihaNaArtiklisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblZalihaNaArtikliCreated(Models.Bssr4.TblZalihaNaArtikli item);
        partial void OnAfterTblZalihaNaArtikliCreated(Models.Bssr4.TblZalihaNaArtikli item);

        public async Task<Models.Bssr4.TblZalihaNaArtikli> CreateTblZalihaNaArtikli(Models.Bssr4.TblZalihaNaArtikli tblZalihaNaArtikli)
        {
            OnTblZalihaNaArtikliCreated(tblZalihaNaArtikli);

            context.TblZalihaNaArtiklis.Add(tblZalihaNaArtikli);
            context.SaveChanges();

            OnAfterTblZalihaNaArtikliCreated(tblZalihaNaArtikli);

            return tblZalihaNaArtikli;
        }
        public async Task ExportTblZiroSmetkisToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzirosmetkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzirosmetkis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportTblZiroSmetkisToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/bssr4/tblzirosmetkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/bssr4/tblzirosmetkis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnTblZiroSmetkisRead(ref IQueryable<Models.Bssr4.TblZiroSmetki> items);

        public async Task<IQueryable<Models.Bssr4.TblZiroSmetki>> GetTblZiroSmetkis(Query query = null)
        {
            var items = context.TblZiroSmetkis.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblZiroSmetkisRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblZiroSmetkiCreated(Models.Bssr4.TblZiroSmetki item);
        partial void OnAfterTblZiroSmetkiCreated(Models.Bssr4.TblZiroSmetki item);

        public async Task<Models.Bssr4.TblZiroSmetki> CreateTblZiroSmetki(Models.Bssr4.TblZiroSmetki tblZiroSmetki)
        {
            OnTblZiroSmetkiCreated(tblZiroSmetki);

            context.TblZiroSmetkis.Add(tblZiroSmetki);
            context.SaveChanges();

            OnAfterTblZiroSmetkiCreated(tblZiroSmetki);

            return tblZiroSmetki;
        }

        partial void OnChangelogDeleted(Models.Bssr4.Changelog item);
        partial void OnAfterChangelogDeleted(Models.Bssr4.Changelog item);

        public async Task<Models.Bssr4.Changelog> DeleteChangelog(int? changeNumber)
        {
            var item = context.Changelogs
                              .Where(i => i.change_number == changeNumber)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnChangelogDeleted(item);

            context.Changelogs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterChangelogDeleted(item);

            return item;
        }

        partial void OnChangelogGet(Models.Bssr4.Changelog item);

        public async Task<Models.Bssr4.Changelog> GetChangelogBychangeNumber(int? changeNumber)
        {
            var items = context.Changelogs
                              .AsNoTracking()
                              .Where(i => i.change_number == changeNumber);

            var item = items.FirstOrDefault();

            OnChangelogGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.Changelog> CancelChangelogChanges(Models.Bssr4.Changelog item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnChangelogUpdated(Models.Bssr4.Changelog item);
        partial void OnAfterChangelogUpdated(Models.Bssr4.Changelog item);

        public async Task<Models.Bssr4.Changelog> UpdateChangelog(int? changeNumber, Models.Bssr4.Changelog changelog)
        {
            OnChangelogUpdated(changelog);

            var item = context.Changelogs
                              .Where(i => i.change_number == changeNumber)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(changelog);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterChangelogUpdated(changelog);

            return changelog;
        }

        partial void OnDbVersionDeleted(Models.Bssr4.DbVersion item);
        partial void OnAfterDbVersionDeleted(Models.Bssr4.DbVersion item);

        public async Task<Models.Bssr4.DbVersion> DeleteDbVersion(int? id)
        {
            var item = context.DbVersions
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnDbVersionDeleted(item);

            context.DbVersions.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterDbVersionDeleted(item);

            return item;
        }

        partial void OnDbVersionGet(Models.Bssr4.DbVersion item);

        public async Task<Models.Bssr4.DbVersion> GetDbVersionById(int? id)
        {
            var items = context.DbVersions
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnDbVersionGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.DbVersion> CancelDbVersionChanges(Models.Bssr4.DbVersion item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnDbVersionUpdated(Models.Bssr4.DbVersion item);
        partial void OnAfterDbVersionUpdated(Models.Bssr4.DbVersion item);

        public async Task<Models.Bssr4.DbVersion> UpdateDbVersion(int? id, Models.Bssr4.DbVersion dbVersion)
        {
            OnDbVersionUpdated(dbVersion);

            var item = context.DbVersions
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(dbVersion);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterDbVersionUpdated(dbVersion);

            return dbVersion;
        }

        partial void OnTblAkcijaNaArtikalDeleted(Models.Bssr4.TblAkcijaNaArtikal item);
        partial void OnAfterTblAkcijaNaArtikalDeleted(Models.Bssr4.TblAkcijaNaArtikal item);

        public async Task<Models.Bssr4.TblAkcijaNaArtikal> DeleteTblAkcijaNaArtikal(int? id)
        {
            var item = context.TblAkcijaNaArtikals
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblAkcijaNaArtikalDeleted(item);

            context.TblAkcijaNaArtikals.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblAkcijaNaArtikalDeleted(item);

            return item;
        }

        partial void OnTblAkcijaNaArtikalGet(Models.Bssr4.TblAkcijaNaArtikal item);

        public async Task<Models.Bssr4.TblAkcijaNaArtikal> GetTblAkcijaNaArtikalById(int? id)
        {
            var items = context.TblAkcijaNaArtikals
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblArtikal);

            var item = items.FirstOrDefault();

            OnTblAkcijaNaArtikalGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblAkcijaNaArtikal> CancelTblAkcijaNaArtikalChanges(Models.Bssr4.TblAkcijaNaArtikal item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblAkcijaNaArtikalUpdated(Models.Bssr4.TblAkcijaNaArtikal item);
        partial void OnAfterTblAkcijaNaArtikalUpdated(Models.Bssr4.TblAkcijaNaArtikal item);

        public async Task<Models.Bssr4.TblAkcijaNaArtikal> UpdateTblAkcijaNaArtikal(int? id, Models.Bssr4.TblAkcijaNaArtikal tblAkcijaNaArtikal)
        {
            OnTblAkcijaNaArtikalUpdated(tblAkcijaNaArtikal);

            var item = context.TblAkcijaNaArtikals
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblAkcijaNaArtikal);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblAkcijaNaArtikalUpdated(tblAkcijaNaArtikal);

            return tblAkcijaNaArtikal;
        }

        partial void OnTblArtikalDeleted(Models.Bssr4.TblArtikal item);
        partial void OnAfterTblArtikalDeleted(Models.Bssr4.TblArtikal item);

        public async Task<Models.Bssr4.TblArtikal> DeleteTblArtikal(int? id)
        {
            var item = context.TblArtikals
                              .Where(i => i.ID == id)
                              .Include(i => i.TblNalogStavkis)
                              .Include(i => i.TblNormativStavkis)
                              .Include(i => i.TblPriemStavkis)
                              .Include(i => i.TblAkcijaNaArtikals)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblArtikalDeleted(item);

            context.TblArtikals.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblArtikalDeleted(item);

            return item;
        }

        partial void OnTblArtikalGet(Models.Bssr4.TblArtikal item);

        public async Task<Models.Bssr4.TblArtikal> GetTblArtikalById(int? id)
        {
            var items = context.TblArtikals
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblDdvStavka);

            items = items.Include(i => i.TblPodgrupaId);

            items = items.Include(i => i.TblEdinecniMerki);

            items = items.Include(i => i.TblFirma);

            var item = items.FirstOrDefault();

            OnTblArtikalGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblArtikal> CancelTblArtikalChanges(Models.Bssr4.TblArtikal item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblArtikalUpdated(Models.Bssr4.TblArtikal item);
        partial void OnAfterTblArtikalUpdated(Models.Bssr4.TblArtikal item);

        public async Task<Models.Bssr4.TblArtikal> UpdateTblArtikal(int? id, Models.Bssr4.TblArtikal tblArtikal)
        {
            OnTblArtikalUpdated(tblArtikal);

            var item = context.TblArtikals
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblArtikal);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblArtikalUpdated(tblArtikal);

            return tblArtikal;
        }

        partial void OnTblBankiDeleted(Models.Bssr4.TblBanki item);
        partial void OnAfterTblBankiDeleted(Models.Bssr4.TblBanki item);

        public async Task<Models.Bssr4.TblBanki> DeleteTblBanki(int? id)
        {
            var item = context.TblBankis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblFakturas)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblBankiDeleted(item);

            context.TblBankis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblBankiDeleted(item);

            return item;
        }

        partial void OnTblBankiGet(Models.Bssr4.TblBanki item);

        public async Task<Models.Bssr4.TblBanki> GetTblBankiById(int? id)
        {
            var items = context.TblBankis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblBankiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblBanki> CancelTblBankiChanges(Models.Bssr4.TblBanki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblBankiUpdated(Models.Bssr4.TblBanki item);
        partial void OnAfterTblBankiUpdated(Models.Bssr4.TblBanki item);

        public async Task<Models.Bssr4.TblBanki> UpdateTblBanki(int? id, Models.Bssr4.TblBanki tblBanki)
        {
            OnTblBankiUpdated(tblBanki);

            var item = context.TblBankis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblBanki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblBankiUpdated(tblBanki);

            return tblBanki;
        }

        partial void OnTblConfigDeleted(Models.Bssr4.TblConfig item);
        partial void OnAfterTblConfigDeleted(Models.Bssr4.TblConfig item);

        public async Task<Models.Bssr4.TblConfig> DeleteTblConfig(int? id)
        {
            var item = context.TblConfigs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblConfigDeleted(item);

            context.TblConfigs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblConfigDeleted(item);

            return item;
        }

        partial void OnTblConfigGet(Models.Bssr4.TblConfig item);

        public async Task<Models.Bssr4.TblConfig> GetTblConfigById(int? id)
        {
            var items = context.TblConfigs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblConfigGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblConfig> CancelTblConfigChanges(Models.Bssr4.TblConfig item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblConfigUpdated(Models.Bssr4.TblConfig item);
        partial void OnAfterTblConfigUpdated(Models.Bssr4.TblConfig item);

        public async Task<Models.Bssr4.TblConfig> UpdateTblConfig(int? id, Models.Bssr4.TblConfig tblConfig)
        {
            OnTblConfigUpdated(tblConfig);

            var item = context.TblConfigs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblConfig);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblConfigUpdated(tblConfig);

            return tblConfig;
        }

        partial void OnTblDdvStavkaDeleted(Models.Bssr4.TblDdvStavka item);
        partial void OnAfterTblDdvStavkaDeleted(Models.Bssr4.TblDdvStavka item);

        public async Task<Models.Bssr4.TblDdvStavka> DeleteTblDdvStavka(int? id)
        {
            var item = context.TblDdvStavkas
                              .Where(i => i.ID == id)
                              .Include(i => i.TblArtikals)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblDdvStavkaDeleted(item);

            context.TblDdvStavkas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblDdvStavkaDeleted(item);

            return item;
        }

        partial void OnTblDdvStavkaGet(Models.Bssr4.TblDdvStavka item);

        public async Task<Models.Bssr4.TblDdvStavka> GetTblDdvStavkaById(int? id)
        {
            var items = context.TblDdvStavkas
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblDdvStavkaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblDdvStavka> CancelTblDdvStavkaChanges(Models.Bssr4.TblDdvStavka item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblDdvStavkaUpdated(Models.Bssr4.TblDdvStavka item);
        partial void OnAfterTblDdvStavkaUpdated(Models.Bssr4.TblDdvStavka item);

        public async Task<Models.Bssr4.TblDdvStavka> UpdateTblDdvStavka(int? id, Models.Bssr4.TblDdvStavka tblDdvStavka)
        {
            OnTblDdvStavkaUpdated(tblDdvStavka);

            var item = context.TblDdvStavkas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblDdvStavka);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblDdvStavkaUpdated(tblDdvStavka);

            return tblDdvStavka;
        }

        partial void OnTblDokumentStavkiDeleted(Models.Bssr4.TblDokumentStavki item);
        partial void OnAfterTblDokumentStavkiDeleted(Models.Bssr4.TblDokumentStavki item);

        public async Task<Models.Bssr4.TblDokumentStavki> DeleteTblDokumentStavki(int? id)
        {
            var item = context.TblDokumentStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblDokumentStavkiDeleted(item);

            context.TblDokumentStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblDokumentStavkiDeleted(item);

            return item;
        }

        partial void OnTblDokumentStavkiGet(Models.Bssr4.TblDokumentStavki item);

        public async Task<Models.Bssr4.TblDokumentStavki> GetTblDokumentStavkiById(int? id)
        {
            var items = context.TblDokumentStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblDokumenti);

            var item = items.FirstOrDefault();

            OnTblDokumentStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblDokumentStavki> CancelTblDokumentStavkiChanges(Models.Bssr4.TblDokumentStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblDokumentStavkiUpdated(Models.Bssr4.TblDokumentStavki item);
        partial void OnAfterTblDokumentStavkiUpdated(Models.Bssr4.TblDokumentStavki item);

        public async Task<Models.Bssr4.TblDokumentStavki> UpdateTblDokumentStavki(int? id, Models.Bssr4.TblDokumentStavki tblDokumentStavki)
        {
            OnTblDokumentStavkiUpdated(tblDokumentStavki);

            var item = context.TblDokumentStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblDokumentStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblDokumentStavkiUpdated(tblDokumentStavki);

            return tblDokumentStavki;
        }

        partial void OnTblDokumentiDeleted(Models.Bssr4.TblDokumenti item);
        partial void OnAfterTblDokumentiDeleted(Models.Bssr4.TblDokumenti item);

        public async Task<Models.Bssr4.TblDokumenti> DeleteTblDokumenti(int? id)
        {
            var item = context.TblDokumentis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblKnizenjeMs)
                              .Include(i => i.TblDokumentStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblDokumentiDeleted(item);

            context.TblDokumentis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblDokumentiDeleted(item);

            return item;
        }

        partial void OnTblDokumentiGet(Models.Bssr4.TblDokumenti item);

        public async Task<Models.Bssr4.TblDokumenti> GetTblDokumentiById(int? id)
        {
            var items = context.TblDokumentis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblTipNaDokument);

            items = items.Include(i => i.TblPartneri);

            var item = items.FirstOrDefault();

            OnTblDokumentiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblDokumenti> CancelTblDokumentiChanges(Models.Bssr4.TblDokumenti item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblDokumentiUpdated(Models.Bssr4.TblDokumenti item);
        partial void OnAfterTblDokumentiUpdated(Models.Bssr4.TblDokumenti item);

        public async Task<Models.Bssr4.TblDokumenti> UpdateTblDokumenti(int? id, Models.Bssr4.TblDokumenti tblDokumenti)
        {
            OnTblDokumentiUpdated(tblDokumenti);

            var item = context.TblDokumentis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblDokumenti);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblDokumentiUpdated(tblDokumenti);

            return tblDokumenti;
        }

        partial void OnTblEdinecniMerkiDeleted(Models.Bssr4.TblEdinecniMerki item);
        partial void OnAfterTblEdinecniMerkiDeleted(Models.Bssr4.TblEdinecniMerki item);

        public async Task<Models.Bssr4.TblEdinecniMerki> DeleteTblEdinecniMerki(int? id)
        {
            var item = context.TblEdinecniMerkis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblArtikals)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblEdinecniMerkiDeleted(item);

            context.TblEdinecniMerkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblEdinecniMerkiDeleted(item);

            return item;
        }

        partial void OnTblEdinecniMerkiGet(Models.Bssr4.TblEdinecniMerki item);

        public async Task<Models.Bssr4.TblEdinecniMerki> GetTblEdinecniMerkiById(int? id)
        {
            var items = context.TblEdinecniMerkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblEdinecniMerkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblEdinecniMerki> CancelTblEdinecniMerkiChanges(Models.Bssr4.TblEdinecniMerki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblEdinecniMerkiUpdated(Models.Bssr4.TblEdinecniMerki item);
        partial void OnAfterTblEdinecniMerkiUpdated(Models.Bssr4.TblEdinecniMerki item);

        public async Task<Models.Bssr4.TblEdinecniMerki> UpdateTblEdinecniMerki(int? id, Models.Bssr4.TblEdinecniMerki tblEdinecniMerki)
        {
            OnTblEdinecniMerkiUpdated(tblEdinecniMerki);

            var item = context.TblEdinecniMerkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblEdinecniMerki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblEdinecniMerkiUpdated(tblEdinecniMerki);

            return tblEdinecniMerki;
        }

        partial void OnTblElektronskoPracanjeDeleted(Models.Bssr4.TblElektronskoPracanje item);
        partial void OnAfterTblElektronskoPracanjeDeleted(Models.Bssr4.TblElektronskoPracanje item);

        public async Task<Models.Bssr4.TblElektronskoPracanje> DeleteTblElektronskoPracanje(int? id)
        {
            var item = context.TblElektronskoPracanjes
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblElektronskoPracanjeDeleted(item);

            context.TblElektronskoPracanjes.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblElektronskoPracanjeDeleted(item);

            return item;
        }

        partial void OnTblElektronskoPracanjeGet(Models.Bssr4.TblElektronskoPracanje item);

        public async Task<Models.Bssr4.TblElektronskoPracanje> GetTblElektronskoPracanjeById(int? id)
        {
            var items = context.TblElektronskoPracanjes
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblElektronskoPracanjeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblElektronskoPracanje> CancelTblElektronskoPracanjeChanges(Models.Bssr4.TblElektronskoPracanje item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblElektronskoPracanjeUpdated(Models.Bssr4.TblElektronskoPracanje item);
        partial void OnAfterTblElektronskoPracanjeUpdated(Models.Bssr4.TblElektronskoPracanje item);

        public async Task<Models.Bssr4.TblElektronskoPracanje> UpdateTblElektronskoPracanje(int? id, Models.Bssr4.TblElektronskoPracanje tblElektronskoPracanje)
        {
            OnTblElektronskoPracanjeUpdated(tblElektronskoPracanje);

            var item = context.TblElektronskoPracanjes
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblElektronskoPracanje);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblElektronskoPracanjeUpdated(tblElektronskoPracanje);

            return tblElektronskoPracanje;
        }

        partial void OnTblFakturaDeleted(Models.Bssr4.TblFaktura item);
        partial void OnAfterTblFakturaDeleted(Models.Bssr4.TblFaktura item);

        public async Task<Models.Bssr4.TblFaktura> DeleteTblFaktura(int? id)
        {
            var item = context.TblFakturas
                              .Where(i => i.ID == id)
                              .Include(i => i.TblKnizenjeMs)
                              .Include(i => i.TblFakturaStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblFakturaDeleted(item);

            context.TblFakturas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblFakturaDeleted(item);

            return item;
        }

        partial void OnTblFakturaGet(Models.Bssr4.TblFaktura item);

        public async Task<Models.Bssr4.TblFaktura> GetTblFakturaById(int? id)
        {
            var items = context.TblFakturas
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblPartneri);

            items = items.Include(i => i.TblZiroSmetki);

            items = items.Include(i => i.TblBanki);

            items = items.Include(i => i.TblUser);

            var item = items.FirstOrDefault();

            OnTblFakturaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblFaktura> CancelTblFakturaChanges(Models.Bssr4.TblFaktura item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblFakturaUpdated(Models.Bssr4.TblFaktura item);
        partial void OnAfterTblFakturaUpdated(Models.Bssr4.TblFaktura item);

        public async Task<Models.Bssr4.TblFaktura> UpdateTblFaktura(int? id, Models.Bssr4.TblFaktura tblFaktura)
        {
            OnTblFakturaUpdated(tblFaktura);

            var item = context.TblFakturas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblFaktura);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblFakturaUpdated(tblFaktura);

            return tblFaktura;
        }

        partial void OnTblFakturaStavkiDeleted(Models.Bssr4.TblFakturaStavki item);
        partial void OnAfterTblFakturaStavkiDeleted(Models.Bssr4.TblFakturaStavki item);

        public async Task<Models.Bssr4.TblFakturaStavki> DeleteTblFakturaStavki(int? id)
        {
            var item = context.TblFakturaStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblFakturaStavkiDeleted(item);

            context.TblFakturaStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblFakturaStavkiDeleted(item);

            return item;
        }

        partial void OnTblFakturaStavkiGet(Models.Bssr4.TblFakturaStavki item);

        public async Task<Models.Bssr4.TblFakturaStavki> GetTblFakturaStavkiById(int? id)
        {
            var items = context.TblFakturaStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblFaktura);

            var item = items.FirstOrDefault();

            OnTblFakturaStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblFakturaStavki> CancelTblFakturaStavkiChanges(Models.Bssr4.TblFakturaStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblFakturaStavkiUpdated(Models.Bssr4.TblFakturaStavki item);
        partial void OnAfterTblFakturaStavkiUpdated(Models.Bssr4.TblFakturaStavki item);

        public async Task<Models.Bssr4.TblFakturaStavki> UpdateTblFakturaStavki(int? id, Models.Bssr4.TblFakturaStavki tblFakturaStavki)
        {
            OnTblFakturaStavkiUpdated(tblFakturaStavki);

            var item = context.TblFakturaStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblFakturaStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblFakturaStavkiUpdated(tblFakturaStavki);

            return tblFakturaStavki;
        }

        partial void OnTblFirmaDeleted(Models.Bssr4.TblFirma item);
        partial void OnAfterTblFirmaDeleted(Models.Bssr4.TblFirma item);

        public async Task<Models.Bssr4.TblFirma> DeleteTblFirma(int? id)
        {
            var item = context.TblFirmas
                              .Where(i => i.ID == id)
                              .Include(i => i.TblSmetkas)
                              .Include(i => i.TblNalogs)
                              .Include(i => i.TblArtikals)
                              .Include(i => i.TblGrupaNaArtiklis)
                              .Include(i => i.TblNormativs)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblFirmaDeleted(item);

            context.TblFirmas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblFirmaDeleted(item);

            return item;
        }

        partial void OnTblFirmaGet(Models.Bssr4.TblFirma item);

        public async Task<Models.Bssr4.TblFirma> GetTblFirmaById(int? id)
        {
            var items = context.TblFirmas
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblFirmaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblFirma> CancelTblFirmaChanges(Models.Bssr4.TblFirma item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblFirmaUpdated(Models.Bssr4.TblFirma item);
        partial void OnAfterTblFirmaUpdated(Models.Bssr4.TblFirma item);

        public async Task<Models.Bssr4.TblFirma> UpdateTblFirma(int? id, Models.Bssr4.TblFirma tblFirma)
        {
            OnTblFirmaUpdated(tblFirma);

            var item = context.TblFirmas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblFirma);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblFirmaUpdated(tblFirma);

            return tblFirma;
        }

        partial void OnTblFiskalniSmetkiDeleted(Models.Bssr4.TblFiskalniSmetki item);
        partial void OnAfterTblFiskalniSmetkiDeleted(Models.Bssr4.TblFiskalniSmetki item);

        public async Task<Models.Bssr4.TblFiskalniSmetki> DeleteTblFiskalniSmetki(int? id)
        {
            var item = context.TblFiskalniSmetkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblFiskalniSmetkiDeleted(item);

            context.TblFiskalniSmetkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblFiskalniSmetkiDeleted(item);

            return item;
        }

        partial void OnTblFiskalniSmetkiGet(Models.Bssr4.TblFiskalniSmetki item);

        public async Task<Models.Bssr4.TblFiskalniSmetki> GetTblFiskalniSmetkiById(int? id)
        {
            var items = context.TblFiskalniSmetkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblSmetka);

            var item = items.FirstOrDefault();

            OnTblFiskalniSmetkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblFiskalniSmetki> CancelTblFiskalniSmetkiChanges(Models.Bssr4.TblFiskalniSmetki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblFiskalniSmetkiUpdated(Models.Bssr4.TblFiskalniSmetki item);
        partial void OnAfterTblFiskalniSmetkiUpdated(Models.Bssr4.TblFiskalniSmetki item);

        public async Task<Models.Bssr4.TblFiskalniSmetki> UpdateTblFiskalniSmetki(int? id, Models.Bssr4.TblFiskalniSmetki tblFiskalniSmetki)
        {
            OnTblFiskalniSmetkiUpdated(tblFiskalniSmetki);

            var item = context.TblFiskalniSmetkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblFiskalniSmetki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblFiskalniSmetkiUpdated(tblFiskalniSmetki);

            return tblFiskalniSmetki;
        }

        partial void OnTblGrupaNaArtikliDeleted(Models.Bssr4.TblGrupaNaArtikli item);
        partial void OnAfterTblGrupaNaArtikliDeleted(Models.Bssr4.TblGrupaNaArtikli item);

        public async Task<Models.Bssr4.TblGrupaNaArtikli> DeleteTblGrupaNaArtikli(int? id)
        {
            var item = context.TblGrupaNaArtiklis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblPodgrupaIds)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblGrupaNaArtikliDeleted(item);

            context.TblGrupaNaArtiklis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblGrupaNaArtikliDeleted(item);

            return item;
        }

        partial void OnTblGrupaNaArtikliGet(Models.Bssr4.TblGrupaNaArtikli item);

        public async Task<Models.Bssr4.TblGrupaNaArtikli> GetTblGrupaNaArtikliById(int? id)
        {
            var items = context.TblGrupaNaArtiklis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblFirma);

            var item = items.FirstOrDefault();

            OnTblGrupaNaArtikliGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblGrupaNaArtikli> CancelTblGrupaNaArtikliChanges(Models.Bssr4.TblGrupaNaArtikli item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGrupaNaArtikliUpdated(Models.Bssr4.TblGrupaNaArtikli item);
        partial void OnAfterTblGrupaNaArtikliUpdated(Models.Bssr4.TblGrupaNaArtikli item);

        public async Task<Models.Bssr4.TblGrupaNaArtikli> UpdateTblGrupaNaArtikli(int? id, Models.Bssr4.TblGrupaNaArtikli tblGrupaNaArtikli)
        {
            OnTblGrupaNaArtikliUpdated(tblGrupaNaArtikli);

            var item = context.TblGrupaNaArtiklis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGrupaNaArtikli);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblGrupaNaArtikliUpdated(tblGrupaNaArtikli);

            return tblGrupaNaArtikli;
        }

        partial void OnTblIzvodiDeleted(Models.Bssr4.TblIzvodi item);
        partial void OnAfterTblIzvodiDeleted(Models.Bssr4.TblIzvodi item);

        public async Task<Models.Bssr4.TblIzvodi> DeleteTblIzvodi(int? id)
        {
            var item = context.TblIzvodis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblIzvodiStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblIzvodiDeleted(item);

            context.TblIzvodis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblIzvodiDeleted(item);

            return item;
        }

        partial void OnTblIzvodiGet(Models.Bssr4.TblIzvodi item);

        public async Task<Models.Bssr4.TblIzvodi> GetTblIzvodiById(int? id)
        {
            var items = context.TblIzvodis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblIzvodiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblIzvodi> CancelTblIzvodiChanges(Models.Bssr4.TblIzvodi item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIzvodiUpdated(Models.Bssr4.TblIzvodi item);
        partial void OnAfterTblIzvodiUpdated(Models.Bssr4.TblIzvodi item);

        public async Task<Models.Bssr4.TblIzvodi> UpdateTblIzvodi(int? id, Models.Bssr4.TblIzvodi tblIzvodi)
        {
            OnTblIzvodiUpdated(tblIzvodi);

            var item = context.TblIzvodis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIzvodi);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblIzvodiUpdated(tblIzvodi);

            return tblIzvodi;
        }

        partial void OnTblIzvodiStavkiDeleted(Models.Bssr4.TblIzvodiStavki item);
        partial void OnAfterTblIzvodiStavkiDeleted(Models.Bssr4.TblIzvodiStavki item);

        public async Task<Models.Bssr4.TblIzvodiStavki> DeleteTblIzvodiStavki(int? id)
        {
            var item = context.TblIzvodiStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblIzvodiStavkiDeleted(item);

            context.TblIzvodiStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblIzvodiStavkiDeleted(item);

            return item;
        }

        partial void OnTblIzvodiStavkiGet(Models.Bssr4.TblIzvodiStavki item);

        public async Task<Models.Bssr4.TblIzvodiStavki> GetTblIzvodiStavkiById(int? id)
        {
            var items = context.TblIzvodiStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblIzvodi);

            items = items.Include(i => i.TblPartneri);

            var item = items.FirstOrDefault();

            OnTblIzvodiStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblIzvodiStavki> CancelTblIzvodiStavkiChanges(Models.Bssr4.TblIzvodiStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIzvodiStavkiUpdated(Models.Bssr4.TblIzvodiStavki item);
        partial void OnAfterTblIzvodiStavkiUpdated(Models.Bssr4.TblIzvodiStavki item);

        public async Task<Models.Bssr4.TblIzvodiStavki> UpdateTblIzvodiStavki(int? id, Models.Bssr4.TblIzvodiStavki tblIzvodiStavki)
        {
            OnTblIzvodiStavkiUpdated(tblIzvodiStavki);

            var item = context.TblIzvodiStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIzvodiStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblIzvodiStavkiUpdated(tblIzvodiStavki);

            return tblIzvodiStavki;
        }

        partial void OnTblKnizenjeMDeleted(Models.Bssr4.TblKnizenjeM item);
        partial void OnAfterTblKnizenjeMDeleted(Models.Bssr4.TblKnizenjeM item);

        public async Task<Models.Bssr4.TblKnizenjeM> DeleteTblKnizenjeM(int? id)
        {
            var item = context.TblKnizenjeMs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblKnizenjeMDeleted(item);

            context.TblKnizenjeMs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblKnizenjeMDeleted(item);

            return item;
        }

        partial void OnTblKnizenjeMGet(Models.Bssr4.TblKnizenjeM item);

        public async Task<Models.Bssr4.TblKnizenjeM> GetTblKnizenjeMById(int? id)
        {
            var items = context.TblKnizenjeMs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblSmetka);

            items = items.Include(i => i.TblFaktura);

            items = items.Include(i => i.TblPriem);

            items = items.Include(i => i.TblDokumenti);

            var item = items.FirstOrDefault();

            OnTblKnizenjeMGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblKnizenjeM> CancelTblKnizenjeMChanges(Models.Bssr4.TblKnizenjeM item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblKnizenjeMUpdated(Models.Bssr4.TblKnizenjeM item);
        partial void OnAfterTblKnizenjeMUpdated(Models.Bssr4.TblKnizenjeM item);

        public async Task<Models.Bssr4.TblKnizenjeM> UpdateTblKnizenjeM(int? id, Models.Bssr4.TblKnizenjeM tblKnizenjeM)
        {
            OnTblKnizenjeMUpdated(tblKnizenjeM);

            var item = context.TblKnizenjeMs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblKnizenjeM);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblKnizenjeMUpdated(tblKnizenjeM);

            return tblKnizenjeM;
        }

        partial void OnTblKursnaListumDeleted(Models.Bssr4.TblKursnaListum item);
        partial void OnAfterTblKursnaListumDeleted(Models.Bssr4.TblKursnaListum item);

        public async Task<Models.Bssr4.TblKursnaListum> DeleteTblKursnaListum(int? id)
        {
            var item = context.TblKursnaLista
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblKursnaListumDeleted(item);

            context.TblKursnaLista.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblKursnaListumDeleted(item);

            return item;
        }

        partial void OnTblKursnaListumGet(Models.Bssr4.TblKursnaListum item);

        public async Task<Models.Bssr4.TblKursnaListum> GetTblKursnaListumById(int? id)
        {
            var items = context.TblKursnaLista
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblKursnaListumGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblKursnaListum> CancelTblKursnaListumChanges(Models.Bssr4.TblKursnaListum item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblKursnaListumUpdated(Models.Bssr4.TblKursnaListum item);
        partial void OnAfterTblKursnaListumUpdated(Models.Bssr4.TblKursnaListum item);

        public async Task<Models.Bssr4.TblKursnaListum> UpdateTblKursnaListum(int? id, Models.Bssr4.TblKursnaListum tblKursnaListum)
        {
            OnTblKursnaListumUpdated(tblKursnaListum);

            var item = context.TblKursnaLista
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblKursnaListum);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblKursnaListumUpdated(tblKursnaListum);

            return tblKursnaListum;
        }

        partial void OnTblLogDeleted(Models.Bssr4.TblLog item);
        partial void OnAfterTblLogDeleted(Models.Bssr4.TblLog item);

        public async Task<Models.Bssr4.TblLog> DeleteTblLog(Int64? id)
        {
            var item = context.TblLogs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblLogDeleted(item);

            context.TblLogs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblLogDeleted(item);

            return item;
        }

        partial void OnTblLogGet(Models.Bssr4.TblLog item);

        public async Task<Models.Bssr4.TblLog> GetTblLogById(Int64? id)
        {
            var items = context.TblLogs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblSesija);

            var item = items.FirstOrDefault();

            OnTblLogGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblLog> CancelTblLogChanges(Models.Bssr4.TblLog item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblLogUpdated(Models.Bssr4.TblLog item);
        partial void OnAfterTblLogUpdated(Models.Bssr4.TblLog item);

        public async Task<Models.Bssr4.TblLog> UpdateTblLog(Int64? id, Models.Bssr4.TblLog tblLog)
        {
            OnTblLogUpdated(tblLog);

            var item = context.TblLogs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblLog);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblLogUpdated(tblLog);

            return tblLog;
        }

        partial void OnTblNalogDeleted(Models.Bssr4.TblNalog item);
        partial void OnAfterTblNalogDeleted(Models.Bssr4.TblNalog item);

        public async Task<Models.Bssr4.TblNalog> DeleteTblNalog(int? id)
        {
            var item = context.TblNalogs
                              .Where(i => i.ID == id)
                              .Include(i => i.TblNalogStavkis)
                              .Include(i => i.TblSmetkaStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNalogDeleted(item);

            context.TblNalogs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNalogDeleted(item);

            return item;
        }

        partial void OnTblNalogGet(Models.Bssr4.TblNalog item);

        public async Task<Models.Bssr4.TblNalog> GetTblNalogById(int? id)
        {
            var items = context.TblNalogs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblFirma);

            var item = items.FirstOrDefault();

            OnTblNalogGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNalog> CancelTblNalogChanges(Models.Bssr4.TblNalog item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNalogUpdated(Models.Bssr4.TblNalog item);
        partial void OnAfterTblNalogUpdated(Models.Bssr4.TblNalog item);

        public async Task<Models.Bssr4.TblNalog> UpdateTblNalog(int? id, Models.Bssr4.TblNalog tblNalog)
        {
            OnTblNalogUpdated(tblNalog);

            var item = context.TblNalogs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNalog);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNalogUpdated(tblNalog);

            return tblNalog;
        }

        partial void OnTblNalogStavkiDeleted(Models.Bssr4.TblNalogStavki item);
        partial void OnAfterTblNalogStavkiDeleted(Models.Bssr4.TblNalogStavki item);

        public async Task<Models.Bssr4.TblNalogStavki> DeleteTblNalogStavki(int? id)
        {
            var item = context.TblNalogStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNalogStavkiDeleted(item);

            context.TblNalogStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNalogStavkiDeleted(item);

            return item;
        }

        partial void OnTblNalogStavkiGet(Models.Bssr4.TblNalogStavki item);

        public async Task<Models.Bssr4.TblNalogStavki> GetTblNalogStavkiById(int? id)
        {
            var items = context.TblNalogStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblNalog);

            items = items.Include(i => i.TblNormativ);

            items = items.Include(i => i.TblArtikal);

            var item = items.FirstOrDefault();

            OnTblNalogStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNalogStavki> CancelTblNalogStavkiChanges(Models.Bssr4.TblNalogStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNalogStavkiUpdated(Models.Bssr4.TblNalogStavki item);
        partial void OnAfterTblNalogStavkiUpdated(Models.Bssr4.TblNalogStavki item);

        public async Task<Models.Bssr4.TblNalogStavki> UpdateTblNalogStavki(int? id, Models.Bssr4.TblNalogStavki tblNalogStavki)
        {
            OnTblNalogStavkiUpdated(tblNalogStavki);

            var item = context.TblNalogStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNalogStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNalogStavkiUpdated(tblNalogStavki);

            return tblNalogStavki;
        }

        partial void OnTblNalogStavkiIzmenetumDeleted(Models.Bssr4.TblNalogStavkiIzmenetum item);
        partial void OnAfterTblNalogStavkiIzmenetumDeleted(Models.Bssr4.TblNalogStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblNalogStavkiIzmenetum> DeleteTblNalogStavkiIzmenetum(int? id)
        {
            var item = context.TblNalogStavkiIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNalogStavkiIzmenetumDeleted(item);

            context.TblNalogStavkiIzmeneta.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNalogStavkiIzmenetumDeleted(item);

            return item;
        }

        partial void OnTblNalogStavkiIzmenetumGet(Models.Bssr4.TblNalogStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblNalogStavkiIzmenetum> GetTblNalogStavkiIzmenetumById(int? id)
        {
            var items = context.TblNalogStavkiIzmeneta
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblNalogStavkiIzmenetumGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNalogStavkiIzmenetum> CancelTblNalogStavkiIzmenetumChanges(Models.Bssr4.TblNalogStavkiIzmenetum item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNalogStavkiIzmenetumUpdated(Models.Bssr4.TblNalogStavkiIzmenetum item);
        partial void OnAfterTblNalogStavkiIzmenetumUpdated(Models.Bssr4.TblNalogStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblNalogStavkiIzmenetum> UpdateTblNalogStavkiIzmenetum(int? id, Models.Bssr4.TblNalogStavkiIzmenetum tblNalogStavkiIzmenetum)
        {
            OnTblNalogStavkiIzmenetumUpdated(tblNalogStavkiIzmenetum);

            var item = context.TblNalogStavkiIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNalogStavkiIzmenetum);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNalogStavkiIzmenetumUpdated(tblNalogStavkiIzmenetum);

            return tblNalogStavkiIzmenetum;
        }

        partial void OnTblNarackiDeleted(Models.Bssr4.TblNaracki item);
        partial void OnAfterTblNarackiDeleted(Models.Bssr4.TblNaracki item);

        public async Task<Models.Bssr4.TblNaracki> DeleteTblNaracki(int? id)
        {
            var item = context.TblNarackis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNarackiDeleted(item);

            context.TblNarackis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNarackiDeleted(item);

            return item;
        }

        partial void OnTblNarackiGet(Models.Bssr4.TblNaracki item);

        public async Task<Models.Bssr4.TblNaracki> GetTblNarackiById(int? id)
        {
            var items = context.TblNarackis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblNarackiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNaracki> CancelTblNarackiChanges(Models.Bssr4.TblNaracki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNarackiUpdated(Models.Bssr4.TblNaracki item);
        partial void OnAfterTblNarackiUpdated(Models.Bssr4.TblNaracki item);

        public async Task<Models.Bssr4.TblNaracki> UpdateTblNaracki(int? id, Models.Bssr4.TblNaracki tblNaracki)
        {
            OnTblNarackiUpdated(tblNaracki);

            var item = context.TblNarackis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNaracki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNarackiUpdated(tblNaracki);

            return tblNaracki;
        }

        partial void OnTblNetworkPcDeleted(Models.Bssr4.TblNetworkPc item);
        partial void OnAfterTblNetworkPcDeleted(Models.Bssr4.TblNetworkPc item);

        public async Task<Models.Bssr4.TblNetworkPc> DeleteTblNetworkPc(int? id)
        {
            var item = context.TblNetworkPcs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNetworkPcDeleted(item);

            context.TblNetworkPcs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNetworkPcDeleted(item);

            return item;
        }

        partial void OnTblNetworkPcGet(Models.Bssr4.TblNetworkPc item);

        public async Task<Models.Bssr4.TblNetworkPc> GetTblNetworkPcById(int? id)
        {
            var items = context.TblNetworkPcs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblNetworkPcGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNetworkPc> CancelTblNetworkPcChanges(Models.Bssr4.TblNetworkPc item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNetworkPcUpdated(Models.Bssr4.TblNetworkPc item);
        partial void OnAfterTblNetworkPcUpdated(Models.Bssr4.TblNetworkPc item);

        public async Task<Models.Bssr4.TblNetworkPc> UpdateTblNetworkPc(int? id, Models.Bssr4.TblNetworkPc tblNetworkPc)
        {
            OnTblNetworkPcUpdated(tblNetworkPc);

            var item = context.TblNetworkPcs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNetworkPc);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNetworkPcUpdated(tblNetworkPc);

            return tblNetworkPc;
        }

        partial void OnTblNetworkPclogDeleted(Models.Bssr4.TblNetworkPclog item);
        partial void OnAfterTblNetworkPclogDeleted(Models.Bssr4.TblNetworkPclog item);

        public async Task<Models.Bssr4.TblNetworkPclog> DeleteTblNetworkPclog(int? id)
        {
            var item = context.TblNetworkPclogs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNetworkPclogDeleted(item);

            context.TblNetworkPclogs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNetworkPclogDeleted(item);

            return item;
        }

        partial void OnTblNetworkPclogGet(Models.Bssr4.TblNetworkPclog item);

        public async Task<Models.Bssr4.TblNetworkPclog> GetTblNetworkPclogById(int? id)
        {
            var items = context.TblNetworkPclogs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblNetworkPclogGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNetworkPclog> CancelTblNetworkPclogChanges(Models.Bssr4.TblNetworkPclog item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNetworkPclogUpdated(Models.Bssr4.TblNetworkPclog item);
        partial void OnAfterTblNetworkPclogUpdated(Models.Bssr4.TblNetworkPclog item);

        public async Task<Models.Bssr4.TblNetworkPclog> UpdateTblNetworkPclog(int? id, Models.Bssr4.TblNetworkPclog tblNetworkPclog)
        {
            OnTblNetworkPclogUpdated(tblNetworkPclog);

            var item = context.TblNetworkPclogs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNetworkPclog);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNetworkPclogUpdated(tblNetworkPclog);

            return tblNetworkPclog;
        }

        partial void OnTblNormativDeleted(Models.Bssr4.TblNormativ item);
        partial void OnAfterTblNormativDeleted(Models.Bssr4.TblNormativ item);

        public async Task<Models.Bssr4.TblNormativ> DeleteTblNormativ(int? id)
        {
            var item = context.TblNormativs
                              .Where(i => i.ID == id)
                              .Include(i => i.TblNalogStavkis)
                              .Include(i => i.TblNormativStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNormativDeleted(item);

            context.TblNormativs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNormativDeleted(item);

            return item;
        }

        partial void OnTblNormativGet(Models.Bssr4.TblNormativ item);

        public async Task<Models.Bssr4.TblNormativ> GetTblNormativById(int? id)
        {
            var items = context.TblNormativs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblFirma);

            var item = items.FirstOrDefault();

            OnTblNormativGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNormativ> CancelTblNormativChanges(Models.Bssr4.TblNormativ item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNormativUpdated(Models.Bssr4.TblNormativ item);
        partial void OnAfterTblNormativUpdated(Models.Bssr4.TblNormativ item);

        public async Task<Models.Bssr4.TblNormativ> UpdateTblNormativ(int? id, Models.Bssr4.TblNormativ tblNormativ)
        {
            OnTblNormativUpdated(tblNormativ);

            var item = context.TblNormativs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNormativ);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNormativUpdated(tblNormativ);

            return tblNormativ;
        }

        partial void OnTblNormativStavkiDeleted(Models.Bssr4.TblNormativStavki item);
        partial void OnAfterTblNormativStavkiDeleted(Models.Bssr4.TblNormativStavki item);

        public async Task<Models.Bssr4.TblNormativStavki> DeleteTblNormativStavki(int? id)
        {
            var item = context.TblNormativStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblNormativStavkiDeleted(item);

            context.TblNormativStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblNormativStavkiDeleted(item);

            return item;
        }

        partial void OnTblNormativStavkiGet(Models.Bssr4.TblNormativStavki item);

        public async Task<Models.Bssr4.TblNormativStavki> GetTblNormativStavkiById(int? id)
        {
            var items = context.TblNormativStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblNormativ);

            items = items.Include(i => i.TblArtikal);

            var item = items.FirstOrDefault();

            OnTblNormativStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblNormativStavki> CancelTblNormativStavkiChanges(Models.Bssr4.TblNormativStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblNormativStavkiUpdated(Models.Bssr4.TblNormativStavki item);
        partial void OnAfterTblNormativStavkiUpdated(Models.Bssr4.TblNormativStavki item);

        public async Task<Models.Bssr4.TblNormativStavki> UpdateTblNormativStavki(int? id, Models.Bssr4.TblNormativStavki tblNormativStavki)
        {
            OnTblNormativStavkiUpdated(tblNormativStavki);

            var item = context.TblNormativStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblNormativStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblNormativStavkiUpdated(tblNormativStavki);

            return tblNormativStavki;
        }

        partial void OnTblObjektiDeleted(Models.Bssr4.TblObjekti item);
        partial void OnAfterTblObjektiDeleted(Models.Bssr4.TblObjekti item);

        public async Task<Models.Bssr4.TblObjekti> DeleteTblObjekti(int? id)
        {
            var item = context.TblObjektis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblSmetkas)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblObjektiDeleted(item);

            context.TblObjektis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblObjektiDeleted(item);

            return item;
        }

        partial void OnTblObjektiGet(Models.Bssr4.TblObjekti item);

        public async Task<Models.Bssr4.TblObjekti> GetTblObjektiById(int? id)
        {
            var items = context.TblObjektis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblObjektiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblObjekti> CancelTblObjektiChanges(Models.Bssr4.TblObjekti item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblObjektiUpdated(Models.Bssr4.TblObjekti item);
        partial void OnAfterTblObjektiUpdated(Models.Bssr4.TblObjekti item);

        public async Task<Models.Bssr4.TblObjekti> UpdateTblObjekti(int? id, Models.Bssr4.TblObjekti tblObjekti)
        {
            OnTblObjektiUpdated(tblObjekti);

            var item = context.TblObjektis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblObjekti);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblObjektiUpdated(tblObjekti);

            return tblObjekti;
        }

        partial void OnTblPartneriDeleted(Models.Bssr4.TblPartneri item);
        partial void OnAfterTblPartneriDeleted(Models.Bssr4.TblPartneri item);

        public async Task<Models.Bssr4.TblPartneri> DeleteTblPartneri(int? id)
        {
            var item = context.TblPartneris
                              .Where(i => i.ID == id)
                              .Include(i => i.TblFakturas)
                              .Include(i => i.TblPriems)
                              .Include(i => i.TblSmetkas)
                              .Include(i => i.TblIzvodiStavkis)
                              .Include(i => i.TblDokumentis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPartneriDeleted(item);

            context.TblPartneris.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPartneriDeleted(item);

            return item;
        }

        partial void OnTblPartneriGet(Models.Bssr4.TblPartneri item);

        public async Task<Models.Bssr4.TblPartneri> GetTblPartneriById(int? id)
        {
            var items = context.TblPartneris
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblPartneriGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPartneri> CancelTblPartneriChanges(Models.Bssr4.TblPartneri item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPartneriUpdated(Models.Bssr4.TblPartneri item);
        partial void OnAfterTblPartneriUpdated(Models.Bssr4.TblPartneri item);

        public async Task<Models.Bssr4.TblPartneri> UpdateTblPartneri(int? id, Models.Bssr4.TblPartneri tblPartneri)
        {
            OnTblPartneriUpdated(tblPartneri);

            var item = context.TblPartneris
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPartneri);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPartneriUpdated(tblPartneri);

            return tblPartneri;
        }

        partial void OnTblPodgrupaIdDeleted(Models.Bssr4.TblPodgrupaId item);
        partial void OnAfterTblPodgrupaIdDeleted(Models.Bssr4.TblPodgrupaId item);

        public async Task<Models.Bssr4.TblPodgrupaId> DeleteTblPodgrupaId(int? id)
        {
            var item = context.TblPodgrupaIds
                              .Where(i => i.ID == id)
                              .Include(i => i.TblArtikals)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPodgrupaIdDeleted(item);

            context.TblPodgrupaIds.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPodgrupaIdDeleted(item);

            return item;
        }

        partial void OnTblPodgrupaIdGet(Models.Bssr4.TblPodgrupaId item);

        public async Task<Models.Bssr4.TblPodgrupaId> GetTblPodgrupaIdById(int? id)
        {
            var items = context.TblPodgrupaIds
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblGrupaNaArtikli);

            var item = items.FirstOrDefault();

            OnTblPodgrupaIdGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPodgrupaId> CancelTblPodgrupaIdChanges(Models.Bssr4.TblPodgrupaId item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPodgrupaIdUpdated(Models.Bssr4.TblPodgrupaId item);
        partial void OnAfterTblPodgrupaIdUpdated(Models.Bssr4.TblPodgrupaId item);

        public async Task<Models.Bssr4.TblPodgrupaId> UpdateTblPodgrupaId(int? id, Models.Bssr4.TblPodgrupaId tblPodgrupaId)
        {
            OnTblPodgrupaIdUpdated(tblPodgrupaId);

            var item = context.TblPodgrupaIds
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPodgrupaId);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPodgrupaIdUpdated(tblPodgrupaId);

            return tblPodgrupaId;
        }

        partial void OnTblPresmetkovniEdiniciDeleted(Models.Bssr4.TblPresmetkovniEdinici item);
        partial void OnAfterTblPresmetkovniEdiniciDeleted(Models.Bssr4.TblPresmetkovniEdinici item);

        public async Task<Models.Bssr4.TblPresmetkovniEdinici> DeleteTblPresmetkovniEdinici(int? id)
        {
            var item = context.TblPresmetkovniEdinicis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPresmetkovniEdiniciDeleted(item);

            context.TblPresmetkovniEdinicis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPresmetkovniEdiniciDeleted(item);

            return item;
        }

        partial void OnTblPresmetkovniEdiniciGet(Models.Bssr4.TblPresmetkovniEdinici item);

        public async Task<Models.Bssr4.TblPresmetkovniEdinici> GetTblPresmetkovniEdiniciById(int? id)
        {
            var items = context.TblPresmetkovniEdinicis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblPresmetkovniEdiniciGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPresmetkovniEdinici> CancelTblPresmetkovniEdiniciChanges(Models.Bssr4.TblPresmetkovniEdinici item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPresmetkovniEdiniciUpdated(Models.Bssr4.TblPresmetkovniEdinici item);
        partial void OnAfterTblPresmetkovniEdiniciUpdated(Models.Bssr4.TblPresmetkovniEdinici item);

        public async Task<Models.Bssr4.TblPresmetkovniEdinici> UpdateTblPresmetkovniEdinici(int? id, Models.Bssr4.TblPresmetkovniEdinici tblPresmetkovniEdinici)
        {
            OnTblPresmetkovniEdiniciUpdated(tblPresmetkovniEdinici);

            var item = context.TblPresmetkovniEdinicis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPresmetkovniEdinici);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPresmetkovniEdiniciUpdated(tblPresmetkovniEdinici);

            return tblPresmetkovniEdinici;
        }

        partial void OnTblPrevodiDeleted(Models.Bssr4.TblPrevodi item);
        partial void OnAfterTblPrevodiDeleted(Models.Bssr4.TblPrevodi item);

        public async Task<Models.Bssr4.TblPrevodi> DeleteTblPrevodi(int? id)
        {
            var item = context.TblPrevodis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPrevodiDeleted(item);

            context.TblPrevodis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPrevodiDeleted(item);

            return item;
        }

        partial void OnTblPrevodiGet(Models.Bssr4.TblPrevodi item);

        public async Task<Models.Bssr4.TblPrevodi> GetTblPrevodiById(int? id)
        {
            var items = context.TblPrevodis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblPrevodiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPrevodi> CancelTblPrevodiChanges(Models.Bssr4.TblPrevodi item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPrevodiUpdated(Models.Bssr4.TblPrevodi item);
        partial void OnAfterTblPrevodiUpdated(Models.Bssr4.TblPrevodi item);

        public async Task<Models.Bssr4.TblPrevodi> UpdateTblPrevodi(int? id, Models.Bssr4.TblPrevodi tblPrevodi)
        {
            OnTblPrevodiUpdated(tblPrevodi);

            var item = context.TblPrevodis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPrevodi);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPrevodiUpdated(tblPrevodi);

            return tblPrevodi;
        }

        partial void OnTblPriemDeleted(Models.Bssr4.TblPriem item);
        partial void OnAfterTblPriemDeleted(Models.Bssr4.TblPriem item);

        public async Task<Models.Bssr4.TblPriem> DeleteTblPriem(int? id)
        {
            var item = context.TblPriems
                              .Where(i => i.ID == id)
                              .Include(i => i.TblKnizenjeMs)
                              .Include(i => i.TblPriemStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPriemDeleted(item);

            context.TblPriems.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPriemDeleted(item);

            return item;
        }

        partial void OnTblPriemGet(Models.Bssr4.TblPriem item);

        public async Task<Models.Bssr4.TblPriem> GetTblPriemById(int? id)
        {
            var items = context.TblPriems
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblPartneri);

            var item = items.FirstOrDefault();

            OnTblPriemGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPriem> CancelTblPriemChanges(Models.Bssr4.TblPriem item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPriemUpdated(Models.Bssr4.TblPriem item);
        partial void OnAfterTblPriemUpdated(Models.Bssr4.TblPriem item);

        public async Task<Models.Bssr4.TblPriem> UpdateTblPriem(int? id, Models.Bssr4.TblPriem tblPriem)
        {
            OnTblPriemUpdated(tblPriem);

            var item = context.TblPriems
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPriem);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPriemUpdated(tblPriem);

            return tblPriem;
        }

        partial void OnTblPriemStavkiDeleted(Models.Bssr4.TblPriemStavki item);
        partial void OnAfterTblPriemStavkiDeleted(Models.Bssr4.TblPriemStavki item);

        public async Task<Models.Bssr4.TblPriemStavki> DeleteTblPriemStavki(int? id)
        {
            var item = context.TblPriemStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblPriemStavkiDeleted(item);

            context.TblPriemStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblPriemStavkiDeleted(item);

            return item;
        }

        partial void OnTblPriemStavkiGet(Models.Bssr4.TblPriemStavki item);

        public async Task<Models.Bssr4.TblPriemStavki> GetTblPriemStavkiById(int? id)
        {
            var items = context.TblPriemStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblPriem);

            items = items.Include(i => i.TblArtikal);

            var item = items.FirstOrDefault();

            OnTblPriemStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblPriemStavki> CancelTblPriemStavkiChanges(Models.Bssr4.TblPriemStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPriemStavkiUpdated(Models.Bssr4.TblPriemStavki item);
        partial void OnAfterTblPriemStavkiUpdated(Models.Bssr4.TblPriemStavki item);

        public async Task<Models.Bssr4.TblPriemStavki> UpdateTblPriemStavki(int? id, Models.Bssr4.TblPriemStavki tblPriemStavki)
        {
            OnTblPriemStavkiUpdated(tblPriemStavki);

            var item = context.TblPriemStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPriemStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblPriemStavkiUpdated(tblPriemStavki);

            return tblPriemStavki;
        }

        partial void OnTblSesijaDeleted(Models.Bssr4.TblSesija item);
        partial void OnAfterTblSesijaDeleted(Models.Bssr4.TblSesija item);

        public async Task<Models.Bssr4.TblSesija> DeleteTblSesija(Int64? id)
        {
            var item = context.TblSesijas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSesijaDeleted(item);

            context.TblSesijas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblSesijaDeleted(item);

            return item;
        }

        partial void OnTblSesijaGet(Models.Bssr4.TblSesija item);

        public async Task<Models.Bssr4.TblSesija> GetTblSesijaById(Int64? id)
        {
            var items = context.TblSesijas
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblSesijaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblSesija> CancelTblSesijaChanges(Models.Bssr4.TblSesija item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSesijaUpdated(Models.Bssr4.TblSesija item);
        partial void OnAfterTblSesijaUpdated(Models.Bssr4.TblSesija item);

        public async Task<Models.Bssr4.TblSesija> UpdateTblSesija(Int64? id, Models.Bssr4.TblSesija tblSesija)
        {
            OnTblSesijaUpdated(tblSesija);

            var item = context.TblSesijas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSesija);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblSesijaUpdated(tblSesija);

            return tblSesija;
        }

        partial void OnTblSmetkaDeleted(Models.Bssr4.TblSmetka item);
        partial void OnAfterTblSmetkaDeleted(Models.Bssr4.TblSmetka item);

        public async Task<Models.Bssr4.TblSmetka> DeleteTblSmetka(int? id)
        {
            var item = context.TblSmetkas
                              .Where(i => i.ID == id)
                              .Include(i => i.TblKnizenjeMs)
                              .Include(i => i.TblFiskalniSmetkis)
                              .Include(i => i.TblSmetkaStavkis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSmetkaDeleted(item);

            context.TblSmetkas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblSmetkaDeleted(item);

            return item;
        }

        partial void OnTblSmetkaGet(Models.Bssr4.TblSmetka item);

        public async Task<Models.Bssr4.TblSmetka> GetTblSmetkaById(int? id)
        {
            var items = context.TblSmetkas
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblUser);

            items = items.Include(i => i.TblFirma);

            items = items.Include(i => i.TblObjekti);

            items = items.Include(i => i.TblPartneri);

            var item = items.FirstOrDefault();

            OnTblSmetkaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblSmetka> CancelTblSmetkaChanges(Models.Bssr4.TblSmetka item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSmetkaUpdated(Models.Bssr4.TblSmetka item);
        partial void OnAfterTblSmetkaUpdated(Models.Bssr4.TblSmetka item);

        public async Task<Models.Bssr4.TblSmetka> UpdateTblSmetka(int? id, Models.Bssr4.TblSmetka tblSmetka)
        {
            OnTblSmetkaUpdated(tblSmetka);

            var item = context.TblSmetkas
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSmetka);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblSmetkaUpdated(tblSmetka);

            return tblSmetka;
        }

        partial void OnTblSmetkaIzmenetumDeleted(Models.Bssr4.TblSmetkaIzmenetum item);
        partial void OnAfterTblSmetkaIzmenetumDeleted(Models.Bssr4.TblSmetkaIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaIzmenetum> DeleteTblSmetkaIzmenetum(int? id)
        {
            var item = context.TblSmetkaIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSmetkaIzmenetumDeleted(item);

            context.TblSmetkaIzmeneta.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblSmetkaIzmenetumDeleted(item);

            return item;
        }

        partial void OnTblSmetkaIzmenetumGet(Models.Bssr4.TblSmetkaIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaIzmenetum> GetTblSmetkaIzmenetumById(int? id)
        {
            var items = context.TblSmetkaIzmeneta
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblSmetkaIzmenetumGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblSmetkaIzmenetum> CancelTblSmetkaIzmenetumChanges(Models.Bssr4.TblSmetkaIzmenetum item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSmetkaIzmenetumUpdated(Models.Bssr4.TblSmetkaIzmenetum item);
        partial void OnAfterTblSmetkaIzmenetumUpdated(Models.Bssr4.TblSmetkaIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaIzmenetum> UpdateTblSmetkaIzmenetum(int? id, Models.Bssr4.TblSmetkaIzmenetum tblSmetkaIzmenetum)
        {
            OnTblSmetkaIzmenetumUpdated(tblSmetkaIzmenetum);

            var item = context.TblSmetkaIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSmetkaIzmenetum);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblSmetkaIzmenetumUpdated(tblSmetkaIzmenetum);

            return tblSmetkaIzmenetum;
        }

        partial void OnTblSmetkaStavkiDeleted(Models.Bssr4.TblSmetkaStavki item);
        partial void OnAfterTblSmetkaStavkiDeleted(Models.Bssr4.TblSmetkaStavki item);

        public async Task<Models.Bssr4.TblSmetkaStavki> DeleteTblSmetkaStavki(int? id)
        {
            var item = context.TblSmetkaStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSmetkaStavkiDeleted(item);

            context.TblSmetkaStavkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblSmetkaStavkiDeleted(item);

            return item;
        }

        partial void OnTblSmetkaStavkiGet(Models.Bssr4.TblSmetkaStavki item);

        public async Task<Models.Bssr4.TblSmetkaStavki> GetTblSmetkaStavkiById(int? id)
        {
            var items = context.TblSmetkaStavkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblSmetka);

            items = items.Include(i => i.TblNalog);

            var item = items.FirstOrDefault();

            OnTblSmetkaStavkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblSmetkaStavki> CancelTblSmetkaStavkiChanges(Models.Bssr4.TblSmetkaStavki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSmetkaStavkiUpdated(Models.Bssr4.TblSmetkaStavki item);
        partial void OnAfterTblSmetkaStavkiUpdated(Models.Bssr4.TblSmetkaStavki item);

        public async Task<Models.Bssr4.TblSmetkaStavki> UpdateTblSmetkaStavki(int? id, Models.Bssr4.TblSmetkaStavki tblSmetkaStavki)
        {
            OnTblSmetkaStavkiUpdated(tblSmetkaStavki);

            var item = context.TblSmetkaStavkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSmetkaStavki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblSmetkaStavkiUpdated(tblSmetkaStavki);

            return tblSmetkaStavki;
        }

        partial void OnTblSmetkaStavkiIzmenetumDeleted(Models.Bssr4.TblSmetkaStavkiIzmenetum item);
        partial void OnAfterTblSmetkaStavkiIzmenetumDeleted(Models.Bssr4.TblSmetkaStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaStavkiIzmenetum> DeleteTblSmetkaStavkiIzmenetum(int? id)
        {
            var item = context.TblSmetkaStavkiIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSmetkaStavkiIzmenetumDeleted(item);

            context.TblSmetkaStavkiIzmeneta.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblSmetkaStavkiIzmenetumDeleted(item);

            return item;
        }

        partial void OnTblSmetkaStavkiIzmenetumGet(Models.Bssr4.TblSmetkaStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaStavkiIzmenetum> GetTblSmetkaStavkiIzmenetumById(int? id)
        {
            var items = context.TblSmetkaStavkiIzmeneta
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblSmetkaStavkiIzmenetumGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblSmetkaStavkiIzmenetum> CancelTblSmetkaStavkiIzmenetumChanges(Models.Bssr4.TblSmetkaStavkiIzmenetum item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSmetkaStavkiIzmenetumUpdated(Models.Bssr4.TblSmetkaStavkiIzmenetum item);
        partial void OnAfterTblSmetkaStavkiIzmenetumUpdated(Models.Bssr4.TblSmetkaStavkiIzmenetum item);

        public async Task<Models.Bssr4.TblSmetkaStavkiIzmenetum> UpdateTblSmetkaStavkiIzmenetum(int? id, Models.Bssr4.TblSmetkaStavkiIzmenetum tblSmetkaStavkiIzmenetum)
        {
            OnTblSmetkaStavkiIzmenetumUpdated(tblSmetkaStavkiIzmenetum);

            var item = context.TblSmetkaStavkiIzmeneta
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSmetkaStavkiIzmenetum);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblSmetkaStavkiIzmenetumUpdated(tblSmetkaStavkiIzmenetum);

            return tblSmetkaStavkiIzmenetum;
        }

        partial void OnTblTipNaDokumentDeleted(Models.Bssr4.TblTipNaDokument item);
        partial void OnAfterTblTipNaDokumentDeleted(Models.Bssr4.TblTipNaDokument item);

        public async Task<Models.Bssr4.TblTipNaDokument> DeleteTblTipNaDokument(int? id)
        {
            var item = context.TblTipNaDokuments
                              .Where(i => i.ID == id)
                              .Include(i => i.TblDokumentis)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblTipNaDokumentDeleted(item);

            context.TblTipNaDokuments.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblTipNaDokumentDeleted(item);

            return item;
        }

        partial void OnTblTipNaDokumentGet(Models.Bssr4.TblTipNaDokument item);

        public async Task<Models.Bssr4.TblTipNaDokument> GetTblTipNaDokumentById(int? id)
        {
            var items = context.TblTipNaDokuments
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblTipNaDokumentGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblTipNaDokument> CancelTblTipNaDokumentChanges(Models.Bssr4.TblTipNaDokument item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblTipNaDokumentUpdated(Models.Bssr4.TblTipNaDokument item);
        partial void OnAfterTblTipNaDokumentUpdated(Models.Bssr4.TblTipNaDokument item);

        public async Task<Models.Bssr4.TblTipNaDokument> UpdateTblTipNaDokument(int? id, Models.Bssr4.TblTipNaDokument tblTipNaDokument)
        {
            OnTblTipNaDokumentUpdated(tblTipNaDokument);

            var item = context.TblTipNaDokuments
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblTipNaDokument);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblTipNaDokumentUpdated(tblTipNaDokument);

            return tblTipNaDokument;
        }

        partial void OnTblUserDeleted(Models.Bssr4.TblUser item);
        partial void OnAfterTblUserDeleted(Models.Bssr4.TblUser item);

        public async Task<Models.Bssr4.TblUser> DeleteTblUser(int? id)
        {
            var item = context.TblUsers
                              .Where(i => i.ID == id)
                              .Include(i => i.TblFakturas)
                              .Include(i => i.TblSmetkas)
                              .Include(i => i.TblUserConfigs)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblUserDeleted(item);

            context.TblUsers.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblUserDeleted(item);

            return item;
        }

        partial void OnTblUserGet(Models.Bssr4.TblUser item);

        public async Task<Models.Bssr4.TblUser> GetTblUserById(int? id)
        {
            var items = context.TblUsers
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblUserGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblUser> CancelTblUserChanges(Models.Bssr4.TblUser item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblUserUpdated(Models.Bssr4.TblUser item);
        partial void OnAfterTblUserUpdated(Models.Bssr4.TblUser item);

        public async Task<Models.Bssr4.TblUser> UpdateTblUser(int? id, Models.Bssr4.TblUser tblUser)
        {
            OnTblUserUpdated(tblUser);

            var item = context.TblUsers
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblUser);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblUserUpdated(tblUser);

            return tblUser;
        }

        partial void OnTblUserConfigDeleted(Models.Bssr4.TblUserConfig item);
        partial void OnAfterTblUserConfigDeleted(Models.Bssr4.TblUserConfig item);

        public async Task<Models.Bssr4.TblUserConfig> DeleteTblUserConfig(int? id)
        {
            var item = context.TblUserConfigs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblUserConfigDeleted(item);

            context.TblUserConfigs.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblUserConfigDeleted(item);

            return item;
        }

        partial void OnTblUserConfigGet(Models.Bssr4.TblUserConfig item);

        public async Task<Models.Bssr4.TblUserConfig> GetTblUserConfigById(int? id)
        {
            var items = context.TblUserConfigs
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            items = items.Include(i => i.TblUser);

            var item = items.FirstOrDefault();

            OnTblUserConfigGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblUserConfig> CancelTblUserConfigChanges(Models.Bssr4.TblUserConfig item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblUserConfigUpdated(Models.Bssr4.TblUserConfig item);
        partial void OnAfterTblUserConfigUpdated(Models.Bssr4.TblUserConfig item);

        public async Task<Models.Bssr4.TblUserConfig> UpdateTblUserConfig(int? id, Models.Bssr4.TblUserConfig tblUserConfig)
        {
            OnTblUserConfigUpdated(tblUserConfig);

            var item = context.TblUserConfigs
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblUserConfig);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblUserConfigUpdated(tblUserConfig);

            return tblUserConfig;
        }

        partial void OnTblValutiDeleted(Models.Bssr4.TblValuti item);
        partial void OnAfterTblValutiDeleted(Models.Bssr4.TblValuti item);

        public async Task<Models.Bssr4.TblValuti> DeleteTblValuti(int? id)
        {
            var item = context.TblValutis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblValutiDeleted(item);

            context.TblValutis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblValutiDeleted(item);

            return item;
        }

        partial void OnTblValutiGet(Models.Bssr4.TblValuti item);

        public async Task<Models.Bssr4.TblValuti> GetTblValutiById(int? id)
        {
            var items = context.TblValutis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblValutiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblValuti> CancelTblValutiChanges(Models.Bssr4.TblValuti item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblValutiUpdated(Models.Bssr4.TblValuti item);
        partial void OnAfterTblValutiUpdated(Models.Bssr4.TblValuti item);

        public async Task<Models.Bssr4.TblValuti> UpdateTblValuti(int? id, Models.Bssr4.TblValuti tblValuti)
        {
            OnTblValutiUpdated(tblValuti);

            var item = context.TblValutis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblValuti);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblValutiUpdated(tblValuti);

            return tblValuti;
        }

        partial void OnTblZalihaNaArtikliDeleted(Models.Bssr4.TblZalihaNaArtikli item);
        partial void OnAfterTblZalihaNaArtikliDeleted(Models.Bssr4.TblZalihaNaArtikli item);

        public async Task<Models.Bssr4.TblZalihaNaArtikli> DeleteTblZalihaNaArtikli(int? id)
        {
            var item = context.TblZalihaNaArtiklis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblZalihaNaArtikliDeleted(item);

            context.TblZalihaNaArtiklis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblZalihaNaArtikliDeleted(item);

            return item;
        }

        partial void OnTblZalihaNaArtikliGet(Models.Bssr4.TblZalihaNaArtikli item);

        public async Task<Models.Bssr4.TblZalihaNaArtikli> GetTblZalihaNaArtikliById(int? id)
        {
            var items = context.TblZalihaNaArtiklis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblZalihaNaArtikliGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblZalihaNaArtikli> CancelTblZalihaNaArtikliChanges(Models.Bssr4.TblZalihaNaArtikli item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblZalihaNaArtikliUpdated(Models.Bssr4.TblZalihaNaArtikli item);
        partial void OnAfterTblZalihaNaArtikliUpdated(Models.Bssr4.TblZalihaNaArtikli item);

        public async Task<Models.Bssr4.TblZalihaNaArtikli> UpdateTblZalihaNaArtikli(int? id, Models.Bssr4.TblZalihaNaArtikli tblZalihaNaArtikli)
        {
            OnTblZalihaNaArtikliUpdated(tblZalihaNaArtikli);

            var item = context.TblZalihaNaArtiklis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblZalihaNaArtikli);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblZalihaNaArtikliUpdated(tblZalihaNaArtikli);

            return tblZalihaNaArtikli;
        }

        partial void OnTblZiroSmetkiDeleted(Models.Bssr4.TblZiroSmetki item);
        partial void OnAfterTblZiroSmetkiDeleted(Models.Bssr4.TblZiroSmetki item);

        public async Task<Models.Bssr4.TblZiroSmetki> DeleteTblZiroSmetki(int? id)
        {
            var item = context.TblZiroSmetkis
                              .Where(i => i.ID == id)
                              .Include(i => i.TblFakturas)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblZiroSmetkiDeleted(item);

            context.TblZiroSmetkis.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterTblZiroSmetkiDeleted(item);

            return item;
        }

        partial void OnTblZiroSmetkiGet(Models.Bssr4.TblZiroSmetki item);

        public async Task<Models.Bssr4.TblZiroSmetki> GetTblZiroSmetkiById(int? id)
        {
            var items = context.TblZiroSmetkis
                              .AsNoTracking()
                              .Where(i => i.ID == id);

            var item = items.FirstOrDefault();

            OnTblZiroSmetkiGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Bssr4.TblZiroSmetki> CancelTblZiroSmetkiChanges(Models.Bssr4.TblZiroSmetki item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblZiroSmetkiUpdated(Models.Bssr4.TblZiroSmetki item);
        partial void OnAfterTblZiroSmetkiUpdated(Models.Bssr4.TblZiroSmetki item);

        public async Task<Models.Bssr4.TblZiroSmetki> UpdateTblZiroSmetki(int? id, Models.Bssr4.TblZiroSmetki tblZiroSmetki)
        {
            OnTblZiroSmetkiUpdated(tblZiroSmetki);

            var item = context.TblZiroSmetkis
                              .Where(i => i.ID == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblZiroSmetki);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterTblZiroSmetkiUpdated(tblZiroSmetki);

            return tblZiroSmetki;
        }
    }
}
