using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Genders", Schema = "DUI")]
public partial class TblOptGender
{
    [Key]
    public int GenderId { get; set; }

    [StringLength(20)]
    public string? GenderDescription { get; set; }

    [StringLength(2)]
    public string? GenderAbbreviation { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Gender")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [InverseProperty("Gender")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();

    [InverseProperty("Gender")]
    public virtual ICollection<Witness> Witnesses { get; set; } = new List<Witness>();
}
