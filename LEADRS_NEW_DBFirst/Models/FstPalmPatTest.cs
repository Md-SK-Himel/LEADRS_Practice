using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_PalmPatTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_PalmPatTests_CaseId")]
public partial class FstPalmPatTest
{
    [Key]
    public int PalmPatTestId { get; set; }

    public int CaseId { get; set; }

    public bool TestGiven { get; set; }

    public string? ReasonNotGiven { get; set; }

    public bool StoppedTest { get; set; }

    public bool StatedPalmPat { get; set; }

    public bool UnableToFollow { get; set; }

    [StringLength(2000)]
    public string? UnableToFollowDesc { get; set; }

    public bool StartWrongTime { get; set; }

    [StringLength(2000)]
    public string? StartWrongTimeDesc { get; set; }

    public bool NotCounted { get; set; }

    [StringLength(2000)]
    public string? NotCountedDesc { get; set; }

    public bool RolledHands { get; set; }

    [StringLength(2000)]
    public string? RolledHandDesc { get; set; }

    public bool DoublePat { get; set; }

    [StringLength(2000)]
    public string? DoublePatDesc { get; set; }

    public bool ChoppedPat { get; set; }

    [StringLength(2000)]
    public string? ChoppedPatDesc { get; set; }

    public bool OtherImproperPat { get; set; }

    [StringLength(2000)]
    public string? OtherImproperPatDesc { get; set; }

    public bool NotIncreaseSpeed { get; set; }

    [StringLength(2000)]
    public string? NotIncreaseSpeedDesc { get; set; }

    public bool RotatedHands { get; set; }

    [StringLength(2000)]
    public string? RotatedHandsDesc { get; set; }

    public bool StoppedBeforeTold { get; set; }

    [StringLength(2000)]
    public string? StoppedBeforeToldDesc { get; set; }

    public int TotalPalmPatClues { get; set; }

    [StringLength(2000)]
    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstPalmPatTests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
