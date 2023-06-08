using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("StepOfficerShiftCases", Schema = "DUI")]
[Index("CaseId", Name = "IX_StepOfficerShiftCases_CaseId")]
[Index("StepOfficerShiftId", Name = "IX_StepOfficerShiftCases_StepOfficerShiftId")]
public partial class StepOfficerShiftCase
{
    [Key]
    public int StepOfficerShiftCaseId { get; set; }

    public int StepOfficerShiftId { get; set; }

    public int CaseId { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("StepOfficerShiftCases")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("StepOfficerShiftId")]
    [InverseProperty("StepOfficerShiftCases")]
    public virtual OfficerStepShift StepOfficerShift { get; set; } = null!;
}
