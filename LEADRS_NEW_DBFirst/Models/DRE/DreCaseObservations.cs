using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_OBS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_OBS_DreCaseId", IsUnique = true)]
public class DreCaseObservations : EntityAbstraction
{
    [Key]
    public int DreCaseObservationsId { get; set; }


    #region Attitude

    public bool? AttitudeCooperative { get; set; }
    public bool? AttitudeCombative { get; set; }
    public bool? AttitudeIndifferent { get; set; }
    public bool? AttitudeCocky { get; set; }
    public bool? AttitudeApologetic { get; set; }

    public bool? AttitudeRestless { get; set; }
    public bool? AttitudeDisoriented { get; set; }
    public bool? AttitudeAnxious { get; set; }
    public bool? AttitudeRelaxed { get; set; }
    public bool? AttitudeCareFree { get; set; }
    public bool? AttitudeConfused { get; set; }
    public bool? AttitudeDazed { get; set; }
    public bool? AttitudeParanoid { get; set; }
    public bool? AttitudeTalkative { get; set; }
    public bool? AttitudeUninhibited { get; set; }
    public bool? AttitudeExcited { get; set; }
    public bool? AttitudePassive { get; set; }
    public bool? AttitudeNonCommunicative { get; set; }

    [MaxLength(50)]
    public string AttitudeOther { get; set; }

    #endregion

    #region Balance

    public bool? BalanceSwaying { get; set; }
    public bool? BalanceUnsteady { get; set; }
    public bool? BalanceNeededSupport { get; set; }
    public bool? BalanceFallingDown { get; set; }
    public bool? BalanceNormal { get; set; }
    public bool? BalancePoor { get; set; }
    public bool? BalanceSlow { get; set; }
    public bool? BalanceUncoordinated { get; set; }
    public bool? BalanceSluggish { get; set; }
    public bool? BalanceDepressedReflexes { get; set; }
    public bool? BalanceMoonWalking { get; set; }

    #endregion

    #region Speech

    public bool? SpeechSlurred { get; set; }
    public bool? SpeechIncoherent { get; set; }
    public bool? SpeechThickTongued { get; set; }
    public bool? SpeechSlowMumbled { get; set; }
    public bool? SpeechNormal { get; set; }
    public bool? SpeechSlow { get; set; }
    public bool? SpeechLow { get; set; }
    public bool? SpeechRaspy { get; set; }
    public bool? SpeechRapidFast { get; set; }
    public bool? SpeechIncompleteVerbalResposes { get; set; }

    [MaxLength(50)]
    public string SpeechOther { get; set; }

    #endregion

    #region Walking

    public bool? WalkingStaggering { get; set; }
    public bool? WalkingFalling { get; set; }
    public bool? WalkingHeavyFooted { get; set; }
    public bool? WalkingSwaying { get; set; }
    public bool? WalkingNormal { get; set; }

    #endregion

    #region Breath

    public bool? BreathNormal { get; set; }
    public bool? BreathAlcohol { get; set; }
    public bool? BreathMarijuana { get; set; }
    public bool? BreathChemical { get; set; }
    public bool? BreathBad { get; set; }
    [MaxLength(50)]
    public string BreathOther { get; set; }

    #endregion

    #region Face

    public bool? FaceFlushed { get; set; }
    public bool? FacePale { get; set; }
    public bool? FaceNormal { get; set; }
    public bool? FaceScars { get; set; }
    public bool? FaceOpenSores { get; set; }
    public bool? FaceInjuries { get; set; }
    public bool? FaceFacialItching { get; set; }
    public bool? FaceBlankStare { get; set; }
    public bool? FaceDazedAppearance { get; set; }
    public bool? FaceSryMouth { get; set; }
    public bool? FaceBruxism { get; set; }
    public bool? FaceOnTheNod { get; set; }
    public bool? FaceResidueOfSubstance { get; set; }
    public bool? FaceSweatyPerspiring { get; set; }
    public bool? FaceDryMouth { get; set; }
    [MaxLength(50)]
    public string FaceOther { get; set; }

    #endregion

    #region Eye with Eyelids

    public bool? LensesNone { get; set; }
    public bool? Glasses { get; set; }
    public bool? Contacts { get; set; }
    public bool? ContactsSoft { get; set; }
    public bool? ContactsHard { get; set; }
    public bool? EyesRed { get; set; }
    public bool? EyesWatery { get; set; }
    public bool? EyesBloodShot { get; set; }
    public bool? EyesNormal { get; set; }
    public bool? BlindnessNone { get; set; }
    public bool? BlindnessLeft { get; set; }
    public bool? BlindnessRight { get; set; }
    [MaxLength(500)]
    public string? BlindnessComment { get; set; }

    public bool? EyelidsNormal { get; set; }
    public bool? EyelidsDroopy { get; set; }


    #endregion

    public bool? TrackingEqual { get; set; }
    public bool? TrackingUnequal { get; set; }
    [MaxLength(50)]
    public string TrackingUnequalDesc { get; set; }
    [MaxLength(50)]
    public string CoordinationOther { get; set; }

}
