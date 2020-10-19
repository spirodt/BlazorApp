using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblEdinecniMerki", Schema = "dbo")]
  public partial class TblEdinecniMerki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblArtikal> TblArtikals { get; set; }
    public string Naziv
    {
      get;
      set;
    }
    public string Kratenka
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public int? Status
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
