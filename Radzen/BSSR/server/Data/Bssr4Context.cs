using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Bssr.Models.Bssr4;

namespace Bssr.Data
{
  public partial class Bssr4Context : Microsoft.EntityFrameworkCore.DbContext
  {
    public Bssr4Context(DbContextOptions<Bssr4Context> options):base(options)
    {
    }

    public Bssr4Context()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Bssr.Models.Bssr4.Mat>().HasNoKey();
        builder.Entity<Bssr.Models.Bssr4.MatKujna>().HasNoKey();
        builder.Entity<Bssr.Models.Bssr4.TblArtikalNotUsed>().HasNoKey();
        builder.Entity<Bssr.Models.Bssr4.TblNalogIzmenetum>().HasNoKey();
        builder.Entity<Bssr.Models.Bssr4.TblZabeleshki>().HasNoKey();
        builder.Entity<Bssr.Models.Bssr4.TblAkcijaNaArtikal>()
              .HasOne(i => i.TblArtikal)
              .WithMany(i => i.TblAkcijaNaArtikals)
              .HasForeignKey(i => i.tblArtikalID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .HasOne(i => i.TblDdvStavka)
              .WithMany(i => i.TblArtikals)
              .HasForeignKey(i => i.tblDDVStavkaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .HasOne(i => i.TblPodgrupaId)
              .WithMany(i => i.TblArtikals)
              .HasForeignKey(i => i.PodgrupaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .HasOne(i => i.TblEdinecniMerki)
              .WithMany(i => i.TblArtikals)
              .HasForeignKey(i => i.tblEdinecniMerkiID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .HasOne(i => i.TblFirma)
              .WithMany(i => i.TblArtikals)
              .HasForeignKey(i => i.FirmaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblDokumentStavki>()
              .HasOne(i => i.TblDokumenti)
              .WithMany(i => i.TblDokumentStavkis)
              .HasForeignKey(i => i.tblDokumentID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblDokumenti>()
              .HasOne(i => i.TblTipNaDokument)
              .WithMany(i => i.TblDokumentis)
              .HasForeignKey(i => i.TipNaDokument)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblDokumenti>()
              .HasOne(i => i.TblPartneri)
              .WithMany(i => i.TblDokumentis)
              .HasForeignKey(i => i.tblPartnerID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .HasOne(i => i.TblPartneri)
              .WithMany(i => i.TblFakturas)
              .HasForeignKey(i => i.tblPartnerID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .HasOne(i => i.TblZiroSmetki)
              .WithMany(i => i.TblFakturas)
              .HasForeignKey(i => i.tblZiroSmetkaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .HasOne(i => i.TblBanki)
              .WithMany(i => i.TblFakturas)
              .HasForeignKey(i => i.tblBankaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .HasOne(i => i.TblUser)
              .WithMany(i => i.TblFakturas)
              .HasForeignKey(i => i.tblUserID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFakturaStavki>()
              .HasOne(i => i.TblFaktura)
              .WithMany(i => i.TblFakturaStavkis)
              .HasForeignKey(i => i.tblFakturaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblFiskalniSmetki>()
              .HasOne(i => i.TblSmetka)
              .WithMany(i => i.TblFiskalniSmetkis)
              .HasForeignKey(i => i.tblSmetkaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblGrupaNaArtikli>()
              .HasOne(i => i.TblFirma)
              .WithMany(i => i.TblGrupaNaArtiklis)
              .HasForeignKey(i => i.FirmaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblIzvodiStavki>()
              .HasOne(i => i.TblIzvodi)
              .WithMany(i => i.TblIzvodiStavkis)
              .HasForeignKey(i => i.tblIzvodiID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblIzvodiStavki>()
              .HasOne(i => i.TblPartneri)
              .WithMany(i => i.TblIzvodiStavkis)
              .HasForeignKey(i => i.PartnerID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .HasOne(i => i.TblSmetka)
              .WithMany(i => i.TblKnizenjeMs)
              .HasForeignKey(i => i.tblSmetkaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .HasOne(i => i.TblFaktura)
              .WithMany(i => i.TblKnizenjeMs)
              .HasForeignKey(i => i.tblFakturaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .HasOne(i => i.TblPriem)
              .WithMany(i => i.TblKnizenjeMs)
              .HasForeignKey(i => i.tblPriemID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .HasOne(i => i.TblDokumenti)
              .WithMany(i => i.TblKnizenjeMs)
              .HasForeignKey(i => i.tblDokumentID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblLog>()
              .HasOne(i => i.TblSesija)
              .WithMany(i => i.TblLogs)
              .HasForeignKey(i => i.Sesija)
              .HasPrincipalKey(i => i.Sesija);
        builder.Entity<Bssr.Models.Bssr4.TblNalog>()
              .HasOne(i => i.TblFirma)
              .WithMany(i => i.TblNalogs)
              .HasForeignKey(i => i.FirmaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNalogStavki>()
              .HasOne(i => i.TblNalog)
              .WithMany(i => i.TblNalogStavkis)
              .HasForeignKey(i => i.tblNalogID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNalogStavki>()
              .HasOne(i => i.TblNormativ)
              .WithMany(i => i.TblNalogStavkis)
              .HasForeignKey(i => i.tblNomativID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNalogStavki>()
              .HasOne(i => i.TblArtikal)
              .WithMany(i => i.TblNalogStavkis)
              .HasForeignKey(i => i.tblArtikalID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNormativ>()
              .HasOne(i => i.TblFirma)
              .WithMany(i => i.TblNormativs)
              .HasForeignKey(i => i.FirmaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNormativStavki>()
              .HasOne(i => i.TblNormativ)
              .WithMany(i => i.TblNormativStavkis)
              .HasForeignKey(i => i.tblNormativID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblNormativStavki>()
              .HasOne(i => i.TblArtikal)
              .WithMany(i => i.TblNormativStavkis)
              .HasForeignKey(i => i.tblArtikalID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblPodgrupaId>()
              .HasOne(i => i.TblGrupaNaArtikli)
              .WithMany(i => i.TblPodgrupaIds)
              .HasForeignKey(i => i.GrupaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblPriem>()
              .HasOne(i => i.TblPartneri)
              .WithMany(i => i.TblPriems)
              .HasForeignKey(i => i.tblPartnerID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblPriemStavki>()
              .HasOne(i => i.TblPriem)
              .WithMany(i => i.TblPriemStavkis)
              .HasForeignKey(i => i.tblPriemID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblPriemStavki>()
              .HasOne(i => i.TblArtikal)
              .WithMany(i => i.TblPriemStavkis)
              .HasForeignKey(i => i.tblArtikalID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .HasOne(i => i.TblUser)
              .WithMany(i => i.TblSmetkas)
              .HasForeignKey(i => i.tblUserID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .HasOne(i => i.TblFirma)
              .WithMany(i => i.TblSmetkas)
              .HasForeignKey(i => i.FirmaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .HasOne(i => i.TblObjekti)
              .WithMany(i => i.TblSmetkas)
              .HasForeignKey(i => i.ObjektID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .HasOne(i => i.TblPartneri)
              .WithMany(i => i.TblSmetkas)
              .HasForeignKey(i => i.tblPartnerID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetkaStavki>()
              .HasOne(i => i.TblSmetka)
              .WithMany(i => i.TblSmetkaStavkis)
              .HasForeignKey(i => i.tblSmetkaID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblSmetkaStavki>()
              .HasOne(i => i.TblNalog)
              .WithMany(i => i.TblSmetkaStavkis)
              .HasForeignKey(i => i.tblNalogID)
              .HasPrincipalKey(i => i.ID);
        builder.Entity<Bssr.Models.Bssr4.TblUserConfig>()
              .HasOne(i => i.TblUser)
              .WithMany(i => i.TblUserConfigs)
              .HasForeignKey(i => i.UserID)
              .HasPrincipalKey(i => i.ID);

        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .Property(p => p.NabavnaCena)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .Property(p => p.ProdaznaCena)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .Property(p => p.RedenBroj)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblArtikal>()
              .Property(p => p.CenaNaGolemo)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblConfig>()
              .Property(p => p.Vrednost)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblConfig>()
              .Property(p => p.NivoNaAdministracija)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblConfig>()
              .Property(p => p.Range)
              .HasDefaultValueSql("('0-1')");

        builder.Entity<Bssr.Models.Bssr4.TblFiskalniSmetki>()
              .Property(p => p.Datum)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblNalog>()
              .Property(p => p.Zabeleska)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblNalog>()
              .Property(p => p.DatumPocetok)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblNalogStavki>()
              .Property(p => p.Rabat1)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblNormativ>()
              .Property(p => p.Cena)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblPriemStavki>()
              .Property(p => p.Rabat1)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblPriemStavki>()
              .Property(p => p.Rabat2)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblPriemStavki>()
              .Property(p => p.Rabat3)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblSesija>()
              .Property(p => p.Sesija)
              .HasDefaultValueSql("(newid())");

        builder.Entity<Bssr.Models.Bssr4.TblSesija>()
              .Property(p => p.Pocnata)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblSesija>()
              .Property(p => p.FirmaID)
              .HasDefaultValueSql("((1))");

        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .Property(p => p.DatumPocetok)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .Property(p => p.Zatvorena)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblSmetkaIzmenetum>()
              .Property(p => p.DatumNaIzmena)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblUser>()
              .Property(p => p.Status)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblUserConfig>()
              .Property(p => p.DateOfCreation)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblZalihaNaArtikli>()
              .Property(p => p.Datum)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Bssr.Models.Bssr4.TblZalihaNaArtikli>()
              .Property(p => p.Vlez)
              .HasDefaultValueSql("((0))");

        builder.Entity<Bssr.Models.Bssr4.TblZalihaNaArtikli>()
              .Property(p => p.Izlez)
              .HasDefaultValueSql("((0))");


        builder.Entity<Bssr.Models.Bssr4.Changelog>()
              .Property(p => p.complete_dt)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblAkcijaNaArtikal>()
              .Property(p => p.DatumPocetok)
              .HasColumnType("date");

        builder.Entity<Bssr.Models.Bssr4.TblAkcijaNaArtikal>()
              .Property(p => p.DatumKraj)
              .HasColumnType("date");

        builder.Entity<Bssr.Models.Bssr4.TblDokumenti>()
              .Property(p => p.Datum)
              .HasColumnType("date");

        builder.Entity<Bssr.Models.Bssr4.TblElektronskoPracanje>()
              .Property(p => p.DatumNaPracanje)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblElektronskoPracanje>()
              .Property(p => p.DatumNaPoslednaIzmenaNaStatus)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblElektronskoPracanje>()
              .Property(p => p.DatumNaPotvrda)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblElektronskoPracanje>()
              .Property(p => p.DatumNaKnizenje)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .Property(p => p.Datum)
              .HasColumnType("date");

        builder.Entity<Bssr.Models.Bssr4.TblFaktura>()
              .Property(p => p.Valuta)
              .HasColumnType("date");

        builder.Entity<Bssr.Models.Bssr4.TblFiskalniSmetki>()
              .Property(p => p.Datum)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblIzvodi>()
              .Property(p => p.DatumNaIzvod)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .Property(p => p.DatumNaKnizenje)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .Property(p => p.DatumNaPocetok)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblKnizenjeM>()
              .Property(p => p.DatumNaKraj)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblLog>()
              .Property(p => p.DatumIVreme)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNalog>()
              .Property(p => p.DatumPocetok)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNalog>()
              .Property(p => p.DatumKraj)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNalogIzmenetum>()
              .Property(p => p.DatumPocetok)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNalogIzmenetum>()
              .Property(p => p.DatumKraj)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNalogIzmenetum>()
              .Property(p => p.DatumNaIzmena)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNaracki>()
              .Property(p => p.DatumNaNaracka)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNetworkPc>()
              .Property(p => p.StartTime)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNetworkPc>()
              .Property(p => p.EndTime)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNetworkPclog>()
              .Property(p => p.Datum)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNetworkPclog>()
              .Property(p => p.StartTime)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblNetworkPclog>()
              .Property(p => p.EndTime)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblPriem>()
              .Property(p => p.PriemDatum)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblPriem>()
              .Property(p => p.IspratnicaFakturaDatum)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblPriem>()
              .Property(p => p.DatumNaDospeanost)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblPriem>()
              .Property(p => p.DatumNaKreiranjeNaPriem)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSesija>()
              .Property(p => p.Pocnata)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSesija>()
              .Property(p => p.Zavrsena)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .Property(p => p.DatumPocetok)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetka>()
              .Property(p => p.DatumKraj)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetkaIzmenetum>()
              .Property(p => p.DatumPocetok)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetkaIzmenetum>()
              .Property(p => p.DatumKraj)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetkaIzmenetum>()
              .Property(p => p.DatumNaIzmena)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum>()
              .Property(p => p.DatumNaIzmena)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblUserConfig>()
              .Property(p => p.DateOfCreation)
              .HasColumnType("datetime");

        builder.Entity<Bssr.Models.Bssr4.TblZalihaNaArtikli>()
              .Property(p => p.Datum)
              .HasColumnType("datetime");

        this.OnModelBuilding(builder);
    }


    public DbSet<Bssr.Models.Bssr4.Changelog> Changelogs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.DbVersion> DbVersions
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.Mat> Mats
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.MatKujna> MatKujnas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblAkcijaNaArtikal> TblAkcijaNaArtikals
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblArtikal> TblArtikals
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblArtikalNotUsed> TblArtikalNotUseds
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblBanki> TblBankis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblConfig> TblConfigs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblDdvStavka> TblDdvStavkas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblDokumentStavki> TblDokumentStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblDokumenti> TblDokumentis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblEdinecniMerki> TblEdinecniMerkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblElektronskoPracanje> TblElektronskoPracanjes
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblFaktura> TblFakturas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblFakturaStavki> TblFakturaStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblFirma> TblFirmas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblFiskalniSmetki> TblFiskalniSmetkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblGrupaNaArtikli> TblGrupaNaArtiklis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblIzvodi> TblIzvodis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblIzvodiStavki> TblIzvodiStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblKnizenjeM> TblKnizenjeMs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblKursnaListum> TblKursnaLista
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblLog> TblLogs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNalog> TblNalogs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNalogIzmenetum> TblNalogIzmeneta
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNalogStavki> TblNalogStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNalogStavkiIzmenetum> TblNalogStavkiIzmeneta
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNaracki> TblNarackis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNetworkPc> TblNetworkPcs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNetworkPclog> TblNetworkPclogs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNormativ> TblNormativs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblNormativStavki> TblNormativStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblObjekti> TblObjektis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPartneri> TblPartneris
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPodgrupaId> TblPodgrupaIds
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPresmetkovniEdinici> TblPresmetkovniEdinicis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPrevodi> TblPrevodis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPriem> TblPriems
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblPriemStavki> TblPriemStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblSesija> TblSesijas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblSmetka> TblSmetkas
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblSmetkaIzmenetum> TblSmetkaIzmeneta
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblSmetkaStavki> TblSmetkaStavkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblSmetkaStavkiIzmenetum> TblSmetkaStavkiIzmeneta
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblTipNaDokument> TblTipNaDokuments
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblUser> TblUsers
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblUserConfig> TblUserConfigs
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblValuti> TblValutis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblZabeleshki> TblZabeleshkis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblZalihaNaArtikli> TblZalihaNaArtiklis
    {
      get;
      set;
    }

    public DbSet<Bssr.Models.Bssr4.TblZiroSmetki> TblZiroSmetkis
    {
      get;
      set;
    }
  }
}
