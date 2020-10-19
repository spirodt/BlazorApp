using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPartneri", Schema = "dbo")]
  public partial class TblPartneri
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblFaktura> TblFakturas { get; set; }
    public ICollection<TblPriem> TblPriems { get; set; }
    public ICollection<TblSmetka> TblSmetkas { get; set; }
    public ICollection<TblIzvodiStavki> TblIzvodiStavkis { get; set; }
    public ICollection<TblDokumenti> TblDokumentis { get; set; }
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
    public string Adresa
    {
      get;
      set;
    }
    public string Telefoni
    {
      get;
      set;
    }
    public string Email
    {
      get;
      set;
    }
    public string EDB
    {
      get;
      set;
    }
    public string Mesto
    {
      get;
      set;
    }
    public int Tip
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public int? tblPresmetkovnaEdinicaID
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
