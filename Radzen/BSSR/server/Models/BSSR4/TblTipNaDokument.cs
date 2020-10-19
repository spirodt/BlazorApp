using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblTipNaDokument", Schema = "dbo")]
  public partial class TblTipNaDokument
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblDokumenti> TblDokumentis { get; set; }
    public string Naziv
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public bool SeKnizi
    {
      get;
      set;
    }
    public string ReportFileName
    {
      get;
      set;
    }
    public int TipNaKnizenje
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public string Naslov
    {
      get;
      set;
    }
    public int Interen
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
