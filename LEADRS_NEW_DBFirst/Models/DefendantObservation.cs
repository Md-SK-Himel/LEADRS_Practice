using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantObservations", Schema = "DUI")]
[Index("AlcoholTypeId", Name = "IX_DefendantObservations_AlcoholTypeId")]
[Index("DefendantId", Name = "IX_DefendantObservations_DefendantId", IsUnique = true)]
public partial class DefendantObservation
{
    [Key]
    public int DefendantObservationId { get; set; }

    public int DefendantId { get; set; }

    public string? ClothingDescription { get; set; }

    public bool ClothingDisorderly { get; set; }

    public bool ClothingSoiled { get; set; }

    public bool ClothingStained { get; set; }

    public bool ClothingTorn { get; set; }

    public bool ClothingOrderly { get; set; }

    public bool BalanceSwaying { get; set; }

    public bool BalanceUnsteady { get; set; }

    public bool BalanceNeededSupport { get; set; }

    public bool BalanceFallingDown { get; set; }

    public bool BalanceNormal { get; set; }

    public bool WalkingStaggering { get; set; }

    public bool WalkingFalling { get; set; }

    public bool WalkingSwaying { get; set; }

    public bool WalkingHeavyFooted { get; set; }

    public bool WalkingNormal { get; set; }

    public bool SpeakingSlurred { get; set; }

    public bool SpeakingIncoherent { get; set; }

    public bool SpeakingThickTongued { get; set; }

    public bool SpeakingSlowMumbled { get; set; }

    public bool SpeakingNormal { get; set; }

    public bool EyesRed { get; set; }

    public bool EyesWatering { get; set; }

    public bool EyesDialated { get; set; }

    public bool EyesDroopyEyelids { get; set; }

    public bool EyesNormal { get; set; }

    public int? AlcoholTypeId { get; set; }

    public int? OdorStrength { get; set; }

    public bool AttitudeCooperative { get; set; }

    public bool AttitudeCombative { get; set; }

    public bool AttitudeIndifferent { get; set; }

    public bool AttitudeCocky { get; set; }

    public bool AttitudeApologetic { get; set; }

    public bool AttitudeUncooperative { get; set; }

    public string? UnusualActionsObserved { get; set; }

    public int? ImpairmentAlcoholDrug { get; set; }

    [Column("DrugGroupCNSDepressant")]
    public bool DrugGroupCnsdepressant { get; set; }

    [Column("DrugGroupCNSStimulant")]
    public bool DrugGroupCnsstimulant { get; set; }

    public bool DrugGroupHallucinogen { get; set; }

    public bool DrugGroupAnesthetics { get; set; }

    public bool DrugGroupAnalgesic { get; set; }

    public bool DrugGroupInhalant { get; set; }

    public bool DrugGroupCannabis { get; set; }

    public string? OtherObservationsComments { get; set; }

    public string? WhySuspected { get; set; }

    [Column("DREPresent")]
    public bool Drepresent { get; set; }

    [Column("DREPerformed")]
    public bool Dreperformed { get; set; }

    [Column("WhoPerformedDRE")]
    public string? WhoPerformedDre { get; set; }

    [Column("DRENotPerformedExplaination")]
    public string? DrenotPerformedExplaination { get; set; }

    [Column("DREComments")]
    public string? Drecomments { get; set; }

    [ForeignKey("AlcoholTypeId")]
    [InverseProperty("DefendantObservations")]
    public virtual TblOptAlcoholType? AlcoholType { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantObservation")]
    public virtual Defendant Defendant { get; set; } = null!;
}
