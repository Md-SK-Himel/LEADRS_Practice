using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("StepOfficerShiftZones", Schema = "DUI")]
[Index("OfficerStepShiftId", Name = "IX_StepOfficerShiftZones_OfficerStepShiftId")]
[Index("StepZoneId", Name = "IX_StepOfficerShiftZones_StepZoneId")]
public partial class StepOfficerShiftZone
{
    [Key]
    public int StepOfficerShiftZoneId { get; set; }

    public int OfficerStepShiftId { get; set; }

    public int StepZoneId { get; set; }

    [ForeignKey("OfficerStepShiftId")]
    [InverseProperty("StepOfficerShiftZones")]
    public virtual OfficerStepShift OfficerStepShift { get; set; } = null!;

    [ForeignKey("StepZoneId")]
    [InverseProperty("StepOfficerShiftZones")]
    public virtual StepZone StepZone { get; set; } = null!;
}
