using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_WT", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_WT_DreCaseId", IsUnique = true)]
public class DreCaseWalkTurn : EntityAbstraction
{
    [Key]
    public int DreCaseWTId { get; set; }

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
    [MaxLength(2000)]
    public string OtherComments { get; set; }

    public int? SO_LL { get; set; }
    public int? SO_LR { get; set; }
    public int? SO_RL { get; set; }
    public int? SO_RR { get; set; }


    public bool? Sounds { get; set; }
    public bool? StartsSoon { get; set; }
    public bool? StepOffLine { get; set; }
    public bool? StopsWalking { get; set; }

    public bool? Swaying { get; set; }
    public bool? UnableToPerform { get; set; }
    public bool? UnserstoodInstructions { get; set; }
    public bool? WalkTurnGiven { get; set; }

    public bool? WrongNumberSteps { get; set; }

    [MaxLength(500)]
    public string WTMissesFirstNine { get; set; }
    [MaxLength(500)]
    public string WTMissesSecondNine { get; set; }
    [MaxLength(500)]
    public string WTNAFirstNine { get; set; }
    [MaxLength(500)]
    public string WTNASecondNine { get; set; }
    public bool? WTOther { get; set; }
    [MaxLength(500)]
    public string WTRaisesFirstNine { get; set; }
    [MaxLength(500)]
    public string WTRaisesSecondNine { get; set; }
    public int? WTStepCount { get; set; }
    public int? WTStepCountSecond { get; set; }

    [MaxLength(500)]
    public string WTStepsLeftFirstNine { get; set; }
    [MaxLength(500)]
    public string WTStepsLeftSecondNine { get; set; }
    [MaxLength(500)]
    public string WTStepsRightFirstNine { get; set; }
    [MaxLength(500)]
    public string WTStepsRightSecondNine { get; set; }
    [MaxLength(500)]
    public string WTStopsFirstNine { get; set; }
    [MaxLength(500)]
    public string WTStopsSecondNine { get; set; }
    [MaxLength(500)]
    public string WTTakensFirstNine { get; set; }
    [MaxLength(500)]
    public string WTTakenSecondNine { get; set; }
    [MaxLength(100)]
    public string WalkTurnNoTest { get; set; }
    [MaxLength(100)]
    public string WalkTurnDescribeTurn { get; set; }

    [MaxLength(400)]
    public string OLSComments { get; set; }
    public int? OLSStarts { get; set; }
}
