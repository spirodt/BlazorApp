using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("_tblSesija", Schema = "dbo")]
  public partial class TblSesija
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 ID
    {
      get;
      set;
    }
    public Guid Sesija
    {
      get;
      set;
    }

    public ICollection<TblLog> TblLogs { get; set; }
    public DateTime Pocnata
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public int UserID
    {
      get;
      set;
    }
    public DateTime? Zavrsena
    {
      get;
      set;
    }
  }
}
