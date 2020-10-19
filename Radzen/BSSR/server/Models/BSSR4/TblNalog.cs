using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNalog", Schema = "dbo")]
  public partial class TblNalog
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblNalogStavki> TblNalogStavkis { get; set; }
    public ICollection<TblSmetkaStavki> TblSmetkaStavkis { get; set; }
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
    public TblFirma TblFirma { get; set; }
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
    [Timestamp]
    public Byte[] DataVersion
    {
      get;
      set;
    }
  }
}
