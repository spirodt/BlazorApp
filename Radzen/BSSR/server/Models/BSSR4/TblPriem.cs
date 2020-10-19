using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPriem", Schema = "dbo")]
  public partial class TblPriem
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; }
    public ICollection<TblPriemStavki> TblPriemStavkis { get; set; }
    public int PriemBroj
    {
      get;
      set;
    }
    public DateTime PriemDatum
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
    public int tblUserID
    {
      get;
      set;
    }
    public int ObjektID
    {
      get;
      set;
    }
    public string IspratnicaFakturaBroj
    {
      get;
      set;
    }
    public DateTime? IspratnicaFakturaDatum
    {
      get;
      set;
    }
    public int? ValutaDenovi
    {
      get;
      set;
    }
    public int? KalkulacijaBroj
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public decimal? VkupenIznos
    {
      get;
      set;
    }
    public DateTime? DatumNaDospeanost
    {
      get;
      set;
    }
    public DateTime? DatumNaKreiranjeNaPriem
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
