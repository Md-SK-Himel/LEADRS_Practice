using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OfficerStepShifts", Schema = "DUI")]
[Index("StepGrantTypeId", Name = "IX_OfficerStepShifts_StepGrantTypeId")]
[Index("StepShiftId", Name = "IX_OfficerStepShifts_StepShiftId")]
public partial class OfficerStepShift
{
    [Key]
    public int StepOfficerShiftId { get; set; }

    public int? OfficerId { get; set; }

    public int? DepartmentId { get; set; }

    public DateTime? DateOfShift { get; set; }

    public DateTime? ShiftStart { get; set; }

    public DateTime? ShiftEnd { get; set; }

    [Column("TotalHRSWorked", TypeName = "decimal(5, 2)")]
    public decimal TotalHrsworked { get; set; }

    public int MileageStart { get; set; }

    public int MileageEnd { get; set; }

    public int MileageTotal { get; set; }

    [StringLength(2000)]
    public string? Comments { get; set; }

    public int? StepShiftId { get; set; }

    public int? StepGrantTypeId { get; set; }

    public bool Submitted { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    [ForeignKey("StepGrantTypeId")]
    [InverseProperty("OfficerStepShifts")]
    public virtual TblOptStepGrantType? StepGrantType { get; set; }

    [InverseProperty("StepOfficerShift")]
    public virtual ICollection<StepOfficerShiftCase> StepOfficerShiftCases { get; set; } = new List<StepOfficerShiftCase>();

    [InverseProperty("OfficerStepShift")]
    public virtual ICollection<StepOfficerShiftZone> StepOfficerShiftZones { get; set; } = new List<StepOfficerShiftZone>();

    [ForeignKey("StepShiftId")]
    [InverseProperty("OfficerStepShifts")]
    public virtual StepShift? StepShift { get; set; }
}
