using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblFirma", Schema = "dbo")]
  public partial class TblFirma
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblSmetka> TblSmetkas { get; set; }
    public ICollection<TblNalog> TblNalogs { get; set; }
    public ICollection<TblArtikal> TblArtikals { get; set; }
    public ICollection<TblGrupaNaArtikli> TblGrupaNaArtiklis { get; set; }
    public ICollection<TblNormativ> TblNormativs { get; set; }
    public string ImeNaFirma
    {
      get;
      set;
    }
    public string DanocenBroj
    {
      get;
      set;
    }
    public string BankaDeponent
    {
      get;
      set;
    }
    public string Grad
    {
      get;
      set;
    }
    public string Adresa
    {
      get;
      set;
    }
    public string PostenskiBroj
    {
      get;
      set;
    }
    public string Telefon
    {
      get;
      set;
    }
    public string Faks
    {
      get;
      set;
    }
    public string EMail
    {
      get;
      set;
    }
    public string MaticenBroj
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public Byte[] Image1
    {
      get;
      set;
    }
    public Byte[] Image2
    {
      get;
      set;
    }
    public Byte[] Image3
    {
      get;
      set;
    }
    public string ZiroSmetka
    {
      get;
      set;
    }
    public string txIDFirma
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
