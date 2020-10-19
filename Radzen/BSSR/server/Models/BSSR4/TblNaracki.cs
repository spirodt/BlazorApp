using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNaracki", Schema = "dbo")]
  public partial class TblNaracki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int NarackaBroj
    {
      get;
      set;
    }
    public string Opis
    {
      get;
      set;
    }
    public DateTime DatumNaNaracka
    {
      get;
      set;
    }
    public string Ime
    {
      get;
      set;
    }
    public string Kontakt
    {
      get;
      set;
    }
    public string OdObjekt
    {
      get;
      set;
    }
    public bool Zavrsena
    {
      get;
      set;
    }
    public string KodNaDokument
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
