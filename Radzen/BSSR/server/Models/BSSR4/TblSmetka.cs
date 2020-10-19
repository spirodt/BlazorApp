using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblSmetka", Schema = "dbo")]
  public partial class TblSmetka
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; }
    public ICollection<TblFiskalniSmetki> TblFiskalniSmetkis { get; set; }
    public ICollection<TblSmetkaStavki> TblSmetkaStavkis { get; set; }
    public int Broj
    {
      get;
      set;
    }
    public DateTime DatumPocetok
    {
      get;
      set;
    }
    public DateTime? DatumKraj
    {
      get;
      set;
    }
    public int tblUserID
    {
      get;
      set;
    }
    public TblUser TblUser { get; set; }
    public int Smena_ID
    {
      get;
      set;
    }
    public bool? Zatvorena
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public TblFirma TblFirma { get; set; }
    public int ObjektID
    {
      get;
      set;
    }
    public TblObjekti TblObjekti { get; set; }
    public string Zabeleska
    {
      get;
      set;
    }
    public int? ImaPopust
    {
      get;
      set;
    }
    public decimal? ProcentNaPopust
    {
      get;
      set;
    }
    public int? Izmeneta
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
