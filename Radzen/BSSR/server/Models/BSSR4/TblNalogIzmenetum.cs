using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNalogIzmeneta", Schema = "dbo")]
  public partial class TblNalogIzmenetum
  {
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
    public string Zabeleska
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
    public int FirmaID
    {
      get;
      set;
    }
    public int Smena_ID
    {
      get;
      set;
    }
    public bool? Zavrsen
    {
      get;
      set;
    }
    public int TipNaNalog
    {
      get;
      set;
    }
    public int SmetkaID
    {
      get;
      set;
    }
    public DateTime? DatumNaIzmena
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
