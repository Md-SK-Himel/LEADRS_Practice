using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("ConditionReasonForStops", Schema = "DUI")]
[Index("ConditionId", Name = "IX_ConditionReasonForStops_ConditionId")]
[Index("ReasonForStopId", Name = "IX_ConditionReasonForStops_ReasonForStopId")]
public partial class ConditionReasonForStop
{
    [Key]
    public int ConditionReasonForStopId { get; set; }

    public int ConditionId { get; set; }

    public int ReasonForStopId { get; set; }

    public string? ReasonForStopText { get; set; }

    [Required]
    public bool? Checked { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("ConditionReasonForStops")]
    public virtual Condition Condition { get; set; } = null!;

    [ForeignKey("ReasonForStopId")]
    [InverseProperty("ConditionReasonForStops")]
    public virtual TblOptReasonForStop ReasonForStop { get; set; } = null!;
}
