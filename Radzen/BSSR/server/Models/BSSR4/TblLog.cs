using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("_tblLog", Schema = "dbo")]
  public partial class TblLog
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
    public TblSesija TblSesija { get; set; }
    public string Akcija
    {
      get;
      set;
    }
    public DateTime DatumIVreme
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
  }
}
