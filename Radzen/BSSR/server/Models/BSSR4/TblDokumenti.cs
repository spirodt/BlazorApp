using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblDokumenti", Schema = "dbo")]
  public partial class TblDokumenti
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; }
    public ICollection<TblDokumentStavki> TblDokumentStavkis { get; set; }
    public int Broj
    {
      get;
      set;
    }
    public int TipNaDokument
    {
      get;
      set;
    }
    public TblTipNaDokument TblTipNaDokument { get; set; }
    public DateTime Datum
    {
      get;
      set;
    }
    public int OdObjektID
    {
      get;
      set;
    }
    public int? DoObjektID
    {
      get;
      set;
    }
    public int tblUserID
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public int? tblPartnerID
    {
      get;
      set;
    }
    public TblPartneri TblPartneri { get; set; }
    public int FirmaID
    {
      get;
      set;
    }
    public string KodNaDokument
    {
      get;
      set;
    }
    public string BrojNaDokument
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
