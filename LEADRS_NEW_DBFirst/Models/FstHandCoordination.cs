using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_HandCoordination", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_HandCoordination_CaseId")]
public partial class FstHandCoordination
{
    [Key]
    public int HandCoordinationId { get; set; }

    public int CaseId { get; set; }

    public bool TestGiven { get; set; }

    public string? ReasonNotGiven { get; set; }

    public bool StoppedTest { get; set; }

    public bool StatedHardCoordination { get; set; }

    public bool UnableToFollow { get; set; }

    [StringLength(2000)]
    public string? UnableToFollowDesc { get; set; }

    public bool StartWrongTime { get; set; }

    [StringLength(2000)]
    public string? StartWrongTimeDesc { get; set; }

    public bool ForwardImproperCount { get; set; }

    [StringLength(2000)]
    public string? ForwardImproperCountDesc { get; set; }

    public bool ForwardImproperTouch { get; set; }

    [StringLength(2000)]
    public string? ForwardImproperTouchDesc { get; set; }

    public bool ForwardNotPerform { get; set; }

    [StringLength(2000)]
    public string? ForwardNotPerformDesc { get; set; }

    public bool ClappingImproperCount { get; set; }

    [StringLength(2000)]
    public string? ClappingImproperCountDesc { get; set; }

    public bool ClappingImproperTouch { get; set; }

    [StringLength(2000)]
    public string? ClappingImproperTouchDesc { get; set; }

    public bool ClappingImproperReturn { get; set; }

    [StringLength(2000)]
    public string? ClappingImproperReturnDesc { get; set; }

    public bool ClappingNotPerform { get; set; }

    [StringLength(2000)]
    public string? ClappingNotPerformDesc { get; set; }

    public bool ReturnImproperCount { get; set; }

    [StringLength(2000)]
    public string? ReturnImproperCountDesc { get; set; }

    public bool ReturnImproperTouch { get; set; }

    [StringLength(2000)]
    public string? ReturnImproperTouchDesc { get; set; }

    public bool NotReturnToChest { get; set; }

    [StringLength(2000)]
    public string? NotReturnToChestDesc { get; set; }

    public bool ReturnNotPerform { get; set; }

    [StringLength(2000)]
    public string? ReturnNotPerformDesc { get; set; }

    public bool ImproperPosition { get; set; }

    [StringLength(2000)]
    public string? ImproperPositionDesc { get; set; }

    public bool EndPositionNotPerform { get; set; }

    [StringLength(2000)]
    public string? EndPositionNotPerformDesc { get; set; }

    public int TotalClues { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstHandCoordinations")]
    public virtual CaseHeader Case { get; set; } = null!;
}
