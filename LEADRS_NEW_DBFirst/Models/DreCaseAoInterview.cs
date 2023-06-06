using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_AO_INTERVIEWS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_AO_INTERVIEWS_DreCaseId", IsUnique = true)]
public partial class DreCaseAoInterview
{
    [Key]
    public int InterviewId { get; set; }

    public int DreCaseId { get; set; }

    public DateTime? DateTimeOfArrest { get; set; }

    [StringLength(500)]
    public string? OfficerInterview { get; set; }

    public bool? SubjectOpertingVehicle { get; set; }

    [StringLength(2000)]
    public string? SubjectOpertingVehicleDesc { get; set; }

    [StringLength(2000)]
    public string? SubjectDrivingVehicleDesc { get; set; }

    public bool? SubjectVehicleCrashed { get; set; }

    [StringLength(2000)]
    public string? SubjectVehicleCrashedDesc { get; set; }

    public bool? SubjectSeenSmokeDrink { get; set; }

    [StringLength(2000)]
    public string? SubjectSeenSmokeDrinkDesc { get; set; }

    public bool? SubjectInhalingSubstance { get; set; }

    [StringLength(2000)]
    public string? SubjectInhalingSubstanceDesc { get; set; }

    [StringLength(2000)]
    public string? SubjectRespondingStopDesc { get; set; }

    public bool? SubjectTryConcealOrThrowMaterial { get; set; }

    [StringLength(2000)]
    public string? SubjectTryConcealOrThrowMaterialDesc { get; set; }

    [StringLength(2000)]
    public string? SubjectAttitudeDesc { get; set; }

    [StringLength(2000)]
    public string? SubjectAttitudCompareDesc { get; set; }

    public bool? SubjectComplainedInjury { get; set; }

    [StringLength(2000)]
    public string? SubjectComplainedInjuryDesc { get; set; }

    public bool? SubjectUsedSteetNameDrug { get; set; }

    [StringLength(2000)]
    public string? SubjectUsedSteetNameDrugDesc { get; set; }

    [StringLength(2000)]
    public string? SubjectRespondToOfficer { get; set; }

    public bool? SubjectSpeechAppearSlurred { get; set; }

    [StringLength(2000)]
    public string? SubjectSpeechAppearSlurredDesc { get; set; }

    public bool? SubjectMentionPrescription { get; set; }

    [StringLength(2000)]
    public string? SubjectMentionPrescriptionDesc { get; set; }

    public bool? SubjectFoundMaterial { get; set; }

    [StringLength(2000)]
    public string? SubjectFoundMaterialDesc { get; set; }

    public bool? SubjectFoundInjectionMaterial { get; set; }

    [StringLength(2000)]
    public string? SubjectFoundInjectionMaterialDesc { get; set; }

    public bool? SubjectFoundBallonPlastic { get; set; }

    [StringLength(2000)]
    public string? SubjectFoundBallonPlasticDesc { get; set; }

    public bool? SubjectFoundDrugResidue { get; set; }

    [StringLength(2000)]
    public string? SubjectFoundDrugResidueDesc { get; set; }

    public bool? SubjectFoundPrescriptionBottles { get; set; }

    [StringLength(2000)]
    public string? SubjectFoundPrescriptionBottlesDesc { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseAoInterview")]
    public virtual DreCase DreCase { get; set; } = null!;
}
