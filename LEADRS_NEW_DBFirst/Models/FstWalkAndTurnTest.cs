using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_WalkAndTurnTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_WalkAndTurnTests_CaseId")]
public partial class FstWalkAndTurnTest
{
    [Key]
    public int WalkAndTurnId { get; set; }

    public int CaseId { get; set; }

    public bool WalkTurnGiven { get; set; }

    public string? ReasonNotGiven { get; set; }

    public bool TestStopped { get; set; }

    public bool StatedWalkTurn { get; set; }

    public bool NotKeepBalance { get; set; }

    public string? KeepBalanceExplain { get; set; }

    public bool StartTooSoon { get; set; }

    public string? StartSoonDesc { get; set; }

    public bool StopWhileWalk { get; set; }

    public string? StopWalkDesc { get; set; }

    public bool MissHeelToe { get; set; }

    public string? MissHeelToeDesc { get; set; }

    public bool StepOffLine { get; set; }

    public string? StepsOffLineDesc { get; set; }

    public bool UseArmsToBalance { get; set; }

    public string? ArmsBalanceDesc { get; set; }

    public bool TurnImproperly { get; set; }

    public string? TurnImproperlyDesc { get; set; }

    public bool WrongSteps { get; set; }

    public string? WrongStepsDesc { get; set; }

    public int WalkAndTurnClues { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstWalkAndTurnTests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
