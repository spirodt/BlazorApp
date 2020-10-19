using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblSmetkaIzmeneta", Schema = "dbo")]
  public partial class TblSmetkaIzmenetum
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
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
    public int ObjektID
    {
      get;
      set;
    }
    public string Zabeleska
    {
      get;
      set;
    }
    public int? Izmeneta
    {
      get;
      set;
    }
    public DateTime? DatumNaIzmena
    {
      get;
      set;
    }
    public int? tblSmetkaIzmenetaID
    {
      get;
      set;
    }
    public int? tblPartnerID
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
