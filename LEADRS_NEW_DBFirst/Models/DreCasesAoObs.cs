using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES_AO_OBS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_AO_OBS_DreCaseId", IsUnique = true)]
public partial class DreCasesAoObs
{
    [Key]
    public int ObservationId { get; set; }

    public int DreCaseId { get; set; }

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

    [StringLength(2000)]
    public string? UnusualActions { get; set; }

    [StringLength(1000)]
    public string? DrugSuspected { get; set; }

    [StringLength(1000)]
    public string? DrugWhySuspected { get; set; }

    [Column("DrugCategoryCNSDepressant")]
    public bool DrugCategoryCnsdepressant { get; set; }

    public bool DrugCategoryHallucinogents { get; set; }

    public bool DrugCategoryNarcoticAbalgestic { get; set; }

    public bool DrugCategoryCannabis { get; set; }

    [Column("DrugCategoryCNSStimulants")]
    public bool DrugCategoryCnsstimulants { get; set; }

    [Column("DrugCategoryPCP")]
    public bool DrugCategoryPcp { get; set; }

    public bool DrugCategoryInhalants { get; set; }

    [StringLength(100)]
    public string? DrugReasonSuspected { get; set; }

    [StringLength(100)]
    public string? Comments { get; set; }

    [Column("BAC", TypeName = "decimal(18, 2)")]
    public decimal Bac { get; set; }

    [Column("InstrumentPBT")]
    public bool InstrumentPbt { get; set; }

    public bool InstrumentIntoxilyzer { get; set; }

    public bool InstrumentOther { get; set; }

    public bool InstrumentRefused { get; set; }

    [Column("InstrumentNA")]
    public bool InstrumentNa { get; set; }

    public bool InstrumentPending { get; set; }

    public bool InstrumentWarrant { get; set; }

    [StringLength(100)]
    public string? InstrumentNumber { get; set; }

    [Column("InstrumentPBTDate")]
    public DateTime? InstrumentPbtdate { get; set; }

    public bool? AdditionalBreathPerformed { get; set; }

    [StringLength(20)]
    public string? BreathInstrumentNumber { get; set; }

    public bool? BreathRefused { get; set; }

    [StringLength(10)]
    public string? BreathResults { get; set; }

    public int? TypeAlcoholDrug { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasesAoOb")]
    public virtual DreCase DreCase { get; set; } = null!;
}
