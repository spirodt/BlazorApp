using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblIzvodiStavki", Schema = "dbo")]
  public partial class TblIzvodiStavki
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }
    public int tblIzvodiID
    {
      get;
      set;
    }
    public TblIzvodi TblIzvodi { get; set; }
    public int PartnerID
    {
      get;
      set;
    }
    public TblPartneri TblPartneri { get; set; }
    public decimal Dolzi
    {
      get;
      set;
    }
    public decimal Pobaruva
    {
      get;
      set;
    }
    public int? DokumentID
    {
      get;
      set;
    }
    public int? FakturaID
    {
      get;
      set;
    }
    public int? PriemID
    {
      get;
      set;
    }
    public int? TipNaDokument
    {
      get;
      set;
    }
    public string BrojNaDokument
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
