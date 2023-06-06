using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Step_Grant_Type", Schema = "DUI")]
public partial class TblOptStepGrantType
{
    [Key]
    public int StepGrantTypeId { get; set; }

    [StringLength(50)]
    public string? StepGrantTypeDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("StepGrantType")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();

    [InverseProperty("StepGrantType")]
    public virtual ICollection<OfficerStepShift> OfficerStepShifts { get; set; } = new List<OfficerStepShift>();

    [InverseProperty("StepGrantType")]
    public virtual ICollection<StepShift> StepShifts { get; set; } = new List<StepShift>();

    [InverseProperty("StepGrantType")]
    public virtual ICollection<StepZone> StepZones { get; set; } = new List<StepZone>();
}
