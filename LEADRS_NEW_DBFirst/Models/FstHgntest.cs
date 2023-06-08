using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_HGNTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_HGNTests_CaseId")]
public partial class FstHgntest
{
    [Key]
    [Column("HGNId")]
    public int Hgnid { get; set; }

    public int CaseId { get; set; }

    [Column("HGNGiven")]
    public bool Hgngiven { get; set; }

    public string? ReasonNotGiven { get; set; }

    public bool HeadInjuries { get; set; }

    public string? HeadInjuryExplain { get; set; }

    public bool WearGlass { get; set; }

    public string? WearGlassExplain { get; set; }

    public bool EqualPupilSize { get; set; }

    public string? EqualPupilSizeExplain { get; set; }

    public bool RestingNystaghums { get; set; }

    public bool EqualTracking { get; set; }

    public bool FollowStimulus { get; set; }

    public string? FollowStimulusExplain { get; set; }

    public bool StimulusAboveEyeLevel { get; set; }

    public bool ForwardEmergencyLightsActive { get; set; }

    public bool DefFacingFlashLight { get; set; }

    public string? FlashLightExplain { get; set; }

    [Column("StatedHGN")]
    public bool StatedHgn { get; set; }

    public string? LackOfPursuit { get; set; }

    public bool LackOfPursuitLeft { get; set; }

    public bool LackOfPursuitRight { get; set; }

    public string? MaximumDeviation { get; set; }

    public bool MaxDeviationLeft { get; set; }

    public bool MaxDeviationRight { get; set; }

    public string? NystaghumsPrior { get; set; }

    public bool NystaghumsPriorLeft { get; set; }

    public bool NystaghumsPriorRight { get; set; }

    public bool AngelOfOnset { get; set; }

    public string? AngelOnsetNystaghums { get; set; }

    public bool VerticalNystaghums { get; set; }

    [Column("TotalHGNClues")]
    public int TotalHgnclues { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstHgntests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
