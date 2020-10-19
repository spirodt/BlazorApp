using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblKnizenjeM", Schema = "dbo")]
  public partial class TblKnizenjeM
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int? tblNormativID
    {
      get;
      set;
    }
    public int? tblArtikalID
    {
      get;
      set;
    }
    public int tipNaArtikal
    {
      get;
      set;
    }
    public decimal ProdaznaCena
    {
      get;
      set;
    }
    public decimal Kolicina
    {
      get;
      set;
    }
    public string Sifra
    {
      get;
      set;
    }
    public int tblEdinecnaMerka
    {
      get;
      set;
    }
    public int tblDDVID
    {
      get;
      set;
    }
    public int tipNaKnizenje
    {
      get;
      set;
    }
    public decimal NabavnaCena
    {
      get;
      set;
    }
    public decimal? EdinecnaCena
    {
      get;
      set;
    }
    public decimal IznosSoDDV
    {
      get;
      set;
    }
    public decimal IznosBezDDV
    {
      get;
      set;
    }
    public decimal IznosDDV
    {
      get;
      set;
    }
    public DateTime DatumNaKnizenje
    {
      get;
      set;
    }
    public int tblUserID
    {
      get;
      set;
    }
    public int tblObjektiID
    {
      get;
      set;
    }
    public DateTime DatumNaPocetok
    {
      get;
      set;
    }
    public DateTime DatumNaKraj
    {
      get;
      set;
    }
    public int? tblSmetkaID
    {
      get;
      set;
    }
    public TblSmetka TblSmetka { get; set; }
    public int? tblFakturaID
    {
      get;
      set;
    }
    public TblFaktura TblFaktura { get; set; }
    public int? tblPriemID
    {
      get;
      set;
    }
    public TblPriem TblPriem { get; set; }
    public int? OtpecatenaFiskalna
    {
      get;
      set;
    }
    public int? tblValutaID
    {
      get;
      set;
    }
    public decimal? Rabat
    {
      get;
      set;
    }
    public decimal? IznosNaRabat
    {
      get;
      set;
    }
    public decimal? ProdaznaCenaSoRabat
    {
      get;
      set;
    }
    public int? tblObjektiIDOD
    {
      get;
      set;
    }
    public int? tblObjektiIDDO
    {
      get;
      set;
    }
    public int? tblDokumentID
    {
      get;
      set;
    }
    public TblDokumenti TblDokumenti { get; set; }
    public string KodNaDokument
    {
      get;
      set;
    }
    [Timestamp]
    public Byte[] DataVersion
    {
      get;
      set;
    }
  }
}
