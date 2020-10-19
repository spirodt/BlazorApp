using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPodgrupaID", Schema = "dbo")]
  public partial class TblPodgrupaId
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblArtikal> TblArtikals { get; set; }
    public int GrupaID
    {
      get;
      set;
    }
    public TblGrupaNaArtikli TblGrupaNaArtikli { get; set; }
    public string Naziv
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
    public string Image
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
