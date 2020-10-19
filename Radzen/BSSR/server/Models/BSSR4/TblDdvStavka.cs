using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblDDVStavka", Schema = "dbo")]
  public partial class TblDdvStavka
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
    public decimal Procent
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public int Grupa
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
