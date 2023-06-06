using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_WT", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_WT_DreCaseId", IsUnique = true)]
public partial class DreCaseWt
{
    [Key]
    [Column("DreCaseWTId")]
    public int DreCaseWtid { get; set; }

    public int DreCaseId { get; set; }

    public int? ActualSteps1 { get; set; }

    public int? ActualSteps2 { get; set; }

    public bool? BodyTremos { get; set; }

    public bool? CannotBalance { get; set; }

    public bool? EyelidsTremos { get; set; }

    public bool? ImproperTurn { get; set; }

    public bool? LegTremos { get; set; }

    public bool? MissHellToe { get; set; }

    public bool? MuscleTensions { get; set; }

    public bool? RaisesArms { get; set; }

    [Column("SO_LL")]
    public int SoLl { get; set; }

    [Column("SO_LR")]
    public int SoLr { get; set; }

    [Column("SO_RL")]
    public int SoRl { get; set; }

    [Column("SO_RR")]
    public int SoRr { get; set; }

    public bool? Sounds { get; set; }

    public bool? StartsSoon { get; set; }

    public bool? StepOffLine { get; set; }

    public bool? StopsWalking { get; set; }

    public bool? Swaying { get; set; }

    public bool? UnableToPerform { get; set; }

    public bool? UnserstoodInstructions { get; set; }

    public bool? WalkTurnGiven { get; set; }

    public bool? WrongNumberSteps { get; set; }

    [Column("WTMissesFirstNine")]
    [StringLength(500)]
    public string? WtmissesFirstNine { get; set; }

    [Column("WTMissesSecondNine")]
    [StringLength(500)]
    public string? WtmissesSecondNine { get; set; }

    [Column("WTNAFirstNine")]
    [StringLength(500)]
    public string? WtnafirstNine { get; set; }

    [Column("WTNASecondNine")]
    [StringLength(500)]
    public string? WtnasecondNine { get; set; }

    [Column("WTOther")]
    public bool? Wtother { get; set; }

    [Column("WTRaisesFirstNine")]
    [StringLength(500)]
    public string? WtraisesFirstNine { get; set; }

    [Column("WTRaisesSecondNine")]
    [StringLength(500)]
    public string? WtraisesSecondNine { get; set; }

    [Column("WTStepCount")]
    public int? WtstepCount { get; set; }

    [Column("WTStepCountSecond")]
    public int? WtstepCountSecond { get; set; }

    [Column("WTStepsLeftFirstNine")]
    [StringLength(500)]
    public string? WtstepsLeftFirstNine { get; set; }

    [Column("WTStepsLeftSecondNine")]
    [StringLength(500)]
    public string? WtstepsLeftSecondNine { get; set; }

    [Column("WTStepsRightFirstNine")]
    [StringLength(500)]
    public string? WtstepsRightFirstNine { get; set; }

    [Column("WTStepsRightSecondNine")]
    [StringLength(500)]
    public string? WtstepsRightSecondNine { get; set; }

    [Column("WTStopsFirstNine")]
    [StringLength(500)]
    public string? WtstopsFirstNine { get; set; }

    [Column("WTStopsSecondNine")]
    [StringLength(500)]
    public string? WtstopsSecondNine { get; set; }

    [Column("WTTakensFirstNine")]
    [StringLength(500)]
    public string? WttakensFirstNine { get; set; }

    [Column("WTTakenSecondNine")]
    [StringLength(500)]
    public string? WttakenSecondNine { get; set; }

    [StringLength(100)]
    public string? WalkTurnNoTest { get; set; }

    [Column("OLSComments")]
    [StringLength(400)]
    public string? Olscomments { get; set; }

    [StringLength(2000)]
    public string? OtherComments { get; set; }

    [StringLength(100)]
    public string? WalkTurnDescribeTurn { get; set; }

    [Column("OLSStarts")]
    public int? Olsstarts { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseWt")]
    public virtual DreCase DreCase { get; set; } = null!;
}
