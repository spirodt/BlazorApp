using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("changelog", Schema = "dbo")]
  public partial class Changelog
  {
    [Key]
    public int change_number
    {
      get;
      set;
    }
    public DateTime? complete_dt
    {
      get;
      set;
    }
    public string applied_by
    {
      get;
      set;
    }
    public string description
    {
      get;
      set;
    }
  }
}
