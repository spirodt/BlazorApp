using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bssr.Models.Bssr4
{
  [Table("tblNormativ", Schema = "dbo")]
  public partial class TblNormativ
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public ICollection<TblNalogStavki> TblNalogStavkis { get; set; }
    public ICollection<TblNormativStavki> TblNormativStavkis { get; set; }
    public string Naziv
    {
      get;
      set;
    }
    public int? Status
    {
      get;
      set;
    }
    public int FirmaID
    {
      get;
      set;
    }
    public TblFirma TblFirma { get; set; }
    public string Sifra
    {
      get;
      set;
    }
    public int PodgrupaID
    {
      get;
      set;
    }
    public string KlucniZborovi
    {
      get;
      set;
    }
    public decimal Cena
    {
      get;
      set;
    }
    public int tblDDVStavkaID
    {
      get;
      set;
    }
    public int? RedenBroj
    {
      get;
      set;
    }
    public string AltNaziv
    {
      get;
      set;
    }
    public string AltNaziv2
    {
      get;
      set;
    }
    public string Image
    {
      get;
      set;
    }
    public bool? SePecatiVoKujna
    {
      get;
      set;
    }
    public bool? SePacatiNaSank
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
