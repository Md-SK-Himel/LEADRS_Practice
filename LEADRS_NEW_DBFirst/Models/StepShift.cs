using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("StepShifts", Schema = "DUI")]
[Index("StepGrantTypeId", Name = "IX_StepShifts_StepGrantTypeId")]
public partial class StepShift
{
    [Key]
    public int StepShiftId { get; set; }

    public int? DepartmentId { get; set; }

    public int? LocationId { get; set; }

    public int? StepGrantTypeId { get; set; }

    public DateTime? ShiftStart { get; set; }

    public DateTime? ShiftEnd { get; set; }

    [InverseProperty("StepShift")]
    public virtual ICollection<OfficerStepShift> OfficerStepShifts { get; set; } = new List<OfficerStepShift>();

    [ForeignKey("StepGrantTypeId")]
    [InverseProperty("StepShifts")]
    public virtual TblOptStepGrantType? StepGrantType { get; set; }
}
