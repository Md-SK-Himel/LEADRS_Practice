using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Races", Schema = "DUI")]
public partial class TblOptRace
{
    [Key]
    public int RaceId { get; set; }

    [StringLength(50)]
    public string? RaceDescription { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Race")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [InverseProperty("Race")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();

    [InverseProperty("Race")]
    public virtual ICollection<Witness> Witnesses { get; set; } = new List<Witness>();
}
