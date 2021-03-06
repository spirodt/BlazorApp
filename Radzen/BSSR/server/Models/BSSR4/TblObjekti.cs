using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblObjekti", Schema = "dbo")]
  public partial class TblObjekti
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblSmetka> TblSmetkas { get; set; }
    public string Naziv
    {
      get;
      set;
    }
    public string Sifra
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
