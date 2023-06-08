using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_AO_INTERVIEWS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_AO_INTERVIEWS_DreCaseId", IsUnique = true)]
public class DreCaseArrestingOfficerInterview : EntityAbstraction
{
    [Key]
    public int InterviewId { get; set; }

    public DateTime? DateTimeOfArrest { get; set; }

    [MaxLength(500)]
    public string OfficerInterview { get; set; }

    public bool? SubjectOpertingVehicle { get; set; }
    [MaxLength(2000)]
    public string SubjectOpertingVehicleDesc { get; set; }

    [MaxLength(2000)]
    public string SubjectDrivingVehicleDesc { get; set; }


    public bool? SubjectVehicleCrashed { get; set; }
    [MaxLength(2000)]
    public string SubjectVehicleCrashedDesc { get; set; }

    public bool? SubjectSeenSmokeDrink { get; set; }
    [MaxLength(2000)]
    public string SubjectSeenSmokeDrinkDesc { get; set; }

    public bool? SubjectInhalingSubstance { get; set; }
    [MaxLength(2000)]
    public string SubjectInhalingSubstanceDesc { get; set; }

    [MaxLength(2000)]
    public string SubjectRespondingStopDesc { get; set; }

    public bool? SubjectTryConcealOrThrowMaterial { get; set; }
    [MaxLength(2000)]
    public string SubjectTryConcealOrThrowMaterialDesc { get; set; }

    [MaxLength(2000)]
    public string SubjectAttitudeDesc { get; set; }

    [MaxLength(2000)]
    public string SubjectAttitudCompareDesc { get; set; }

    public bool? SubjectComplainedInjury { get; set; }
    [MaxLength(2000)]
    public string SubjectComplainedInjuryDesc { get; set; }

    public bool? SubjectUsedSteetNameDrug { get; set; }
    [MaxLength(2000)]
    public string SubjectUsedSteetNameDrugDesc { get; set; }

    [MaxLength(2000)]
    public string SubjectRespondToOfficer { get; set; }

    public bool? SubjectSpeechAppearSlurred { get; set; }
    [MaxLength(2000)]
    public string SubjectSpeechAppearSlurredDesc { get; set; }

    public bool? SubjectMentionPrescription { get; set; }
    [MaxLength(2000)]
    public string SubjectMentionPrescriptionDesc { get; set; }

    public bool? SubjectFoundMaterial { get; set; }
    [MaxLength(2000)]
    public string SubjectFoundMaterialDesc { get; set; }

    public bool? SubjectFoundInjectionMaterial { get; set; }
    [MaxLength(2000)]
    public string SubjectFoundInjectionMaterialDesc { get; set; }

    public bool? SubjectFoundBallonPlastic { get; set; }
    [MaxLength(2000)]
    public string SubjectFoundBallonPlasticDesc { get; set; }

    public bool? SubjectFoundDrugResidue { get; set; }
    [MaxLength(2000)]
    public string SubjectFoundDrugResidueDesc { get; set; }

    public bool? SubjectFoundPrescriptionBottles { get; set; }
    [MaxLength(2000)]
    public string SubjectFoundPrescriptionBottlesDesc { get; set; }
}
