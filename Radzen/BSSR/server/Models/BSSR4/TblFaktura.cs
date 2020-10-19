using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblFaktura", Schema = "dbo")]
  public partial class TblFaktura
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; }
    public ICollection<TblFakturaStavki> TblFakturaStavkis { get; set; }
    public int Broj
    {
      get;
      set;
    }
    public DateTime Datum
    {
      get;
      set;
    }
    public int tblPartnerID
    {
      get;
      set;
    }
    public TblPartneri TblPartneri { get; set; }
    public int? tblZiroSmetkaID
    {
      get;
      set;
    }
    public TblZiroSmetki TblZiroSmetki { get; set; }
    public int? tblBankaID
    {
      get;
      set;
    }
    public TblBanki TblBanki { get; set; }
    public int tblUserID
    {
      get;
      set;
    }
    public TblUser TblUser { get; set; }
    public DateTime Valuta
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public string ListaNaIspratnici
    {
      get;
      set;
    }
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
