using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblPrevodi", Schema = "dbo")]
  public partial class TblPrevodi
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public string KlucenZbor
    {
      get;
      set;
    }
    public string MK
    {
      get;
      set;
    }
    public string AL
    {
      get;
      set;
    }
    public string EN
    {
      get;
      set;
    }
    public string SR
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
