using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblArtikal_NotUsed", Schema = "dbo")]
  public partial class TblArtikalNotUsed
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string Sifra
    {
      get;
      set;
    }
    public string Naziv
    {
      get;
      set;
    }
    public int tblDDVStavkaID
    {
      get;
      set;
    }
    public int PodgrupaID
    {
      get;
      set;
    }
    public int tblEdinecniMerkiID
    {
      get;
      set;
    }
    public string AltNaziv
    {
      get;
      set;
    }
    public string AltSifra
    {
      get;
      set;
    }
    public string KlucniZborovi
    {
      get;
      set;
    }
    public decimal? NabavnaCena
    {
      get;
      set;
    }
    public decimal ProdaznaCena
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public int? EDMIzlez
    {
      get;
      set;
    }
    public decimal? KolicinaT
    {
      get;
      set;
    }
    public decimal? MinimalnaKolicinaNaZaliha
    {
      get;
      set;
    }
    public int? RedenBroj
    {
      get;
      set;
    }
    public string Barkod1
    {
      get;
      set;
    }
    public string Barkod2
    {
      get;
      set;
    }
    public string AltNaziv2
    {
      get;
      set;
    }
    public string Image
    {
      get;
      set;
    }
    public bool? SePecatiVoKujna
    {
      get;
      set;
    }
    public bool? SePacatiNaSank
    {
      get;
      set;
    }
    public int? DenoviZaGarancija
    {
      get;
      set;
    }
    public bool? DomasenProizvod
    {
      get;
      set;
    }
    public decimal? CenaNaGolemo
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
