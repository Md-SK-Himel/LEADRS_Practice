using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_FingerToNoseTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_FingerToNoseTests_CaseId")]
public partial class FstFingerToNoseTest
{
    [Key]
    public int FingerToNoseId { get; set; }

    public int CaseId { get; set; }

    public bool TestGiven { get; set; }

    [StringLength(500)]
    public string? ReasonNotGiven { get; set; }

    public bool StoppedTest { get; set; }

    public bool StatedFingerToNose { get; set; }

    public bool UnableToFollow { get; set; }

    [StringLength(2000)]
    public string? UnableToFollowDesc { get; set; }

    public bool StartWrongTime { get; set; }

    [StringLength(2000)]
    public string? StartWrongTimeDesc { get; set; }

    public bool NotCloseEyes { get; set; }

    [StringLength(2000)]
    public string? NotCloseEyesDesc { get; set; }

    public bool NotTiltHead { get; set; }

    [StringLength(2000)]
    public string? NotTiltHeadDesc { get; set; }

    public bool OpenEyes { get; set; }

    [StringLength(2000)]
    public string? OpenEyesDesc { get; set; }

    public bool MovedHead { get; set; }

    [StringLength(2000)]
    public string? MovedHeadDesc { get; set; }

    public bool WrongHandLeft1 { get; set; }

    public bool WrongHandRight1 { get; set; }

    public bool WrongHandLeft2 { get; set; }

    public bool WrongHandRight2 { get; set; }

    public bool WrongHandLeft3 { get; set; }

    public bool WrongHandRight3 { get; set; }

    public bool WrongFingerLeft1 { get; set; }

    public bool WrongFingerRight1 { get; set; }

    public bool WrongFingerLeft2 { get; set; }

    public bool WrongFingerRight2 { get; set; }

    public bool WrongFingerLeft3 { get; set; }

    public bool WrongFingerRight3 { get; set; }

    public bool HesitatedLeft1 { get; set; }

    public bool HesitatedRight1 { get; set; }

    public bool HesitatedLeft2 { get; set; }

    public bool HesitatedRight2 { get; set; }

    public bool HesitatedLeft3 { get; set; }

    public bool HesitatedRight3 { get; set; }

    public bool SearchedLeft1 { get; set; }

    public bool SearchedRight1 { get; set; }

    public bool SearchedLeft2 { get; set; }

    public bool SearchedRight2 { get; set; }

    public bool SearchedLeft3 { get; set; }

    public bool SearchedRight3 { get; set; }

    public bool FingerTipLeft1 { get; set; }

    public bool FingerTipRight1 { get; set; }

    public bool FingerTipLeft2 { get; set; }

    public bool FingerTipRight2 { get; set; }

    public bool FingerTipLeft3 { get; set; }

    public bool FingerTipRight3 { get; set; }

    public bool MissedNoseLeft1 { get; set; }

    public bool MissedNoseRight1 { get; set; }

    public bool MissedNoseLeft2 { get; set; }

    public bool MissedNoseRight2 { get; set; }

    public bool MissedNoseLeft3 { get; set; }

    public bool MissedNoseRight3 { get; set; }

    public bool BringDownLeft1 { get; set; }

    public bool BringDownRight1 { get; set; }

    public bool BringDownLeft2 { get; set; }

    public bool BringDownRight2 { get; set; }

    public bool BringDownLeft3 { get; set; }

    public bool BringDownRight3 { get; set; }

    public int NumberOfClues { get; set; }

    [StringLength(2000)]
    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstFingerToNoseTests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
