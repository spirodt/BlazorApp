using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("DbVersion", Schema = "dbo")]
  public partial class DbVersion
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    [Column("DbVersion")]
    public string DbVersion1
    {
      get;
      set;
    }
    public string LastAlterScriptName
    {
      get;
      set;
    }
  }
}
