using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_AO_OBS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_AO_OBS_DreCaseId", IsUnique = true)]
public class DreCaseArrestingOfficerObservation : EntityAbstraction
{
    [Key]
    public int ObservationId { get; set; }


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

    public bool SpeechSlurred { get; set; }
    public bool SpeechIncoherent { get; set; }
    public bool SpeechThickTongued { get; set; }
    public bool SpeechSlowMumbled { get; set; }
    public bool SpeechNormal { get; set; }

    public bool EyesRed { get; set; }
    public bool EyesWatering { get; set; }
    public bool EyesDilated { get; set; }
    public bool EyesDroopyEyeLids { get; set; }
    public bool EyesNormal { get; set; }

    public bool AttitudeUnCooperative { get; set; }
    public bool AttitudeCooperative { get; set; }
    public bool AttitudeCombative { get; set; }
    public bool AttitudeIndifferent { get; set; }
    public bool AttitudeCocky { get; set; }
    public bool AttitudeApologetic { get; set; }

    public int? TypeOfAlcohol { get; set; }

    [MaxLength(2000)]
    public string UnusualActions { get; set; }

    [MaxLength(1000)]
    public string DrugSuspected { get; set; }
    [MaxLength(1000)]
    public string DrugWhySuspected { get; set; }

    public bool? DrugCategoryCNSDepressant { get; set; }
    public bool? DrugCategoryHallucinogents { get; set; }
    public bool? DrugCategoryNarcoticAbalgestic { get; set; }
    public bool? DrugCategoryCannabis { get; set; }
    public bool? DrugCategoryCNSStimulants { get; set; }
    public bool DrugCategoryPCP { get; set; }
    public bool? DrugCategoryInhalants { get; set; }

    [MaxLength(100)]
    public string DrugReasonSuspected { get; set; }
    [MaxLength(100)]
    public string Comments { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BAC { get; set; }

    public bool? InstrumentPBT { get; set; }
    public bool? InstrumentIntoxilyzer { get; set; }
    public bool? InstrumentOther { get; set; }
    public bool? InstrumentRefused { get; set; }
    public bool? InstrumentNA { get; set; }
    public bool? InstrumentPending { get; set; }
    public bool? InstrumentWarrant { get; set; }

    [MaxLength(100)]
    public string InstrumentNumber { get; set; }

    public DateTime? InstrumentPBTDate { get; set; }
    public bool? AdditionalBreathPerformed { get; set; }


    // Newly added for missing fields
    public int? TypeAlcoholDrug { get; set; }
    public bool? BreathRefused { get; set; }
    [MaxLength(10)]
    public string BreathResults { get; set; }
    [MaxLength(20)]
    public string BreathInstrumentNumber { get; set; }
}
