using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES", Schema = "DRE")]
[Index("DreNotifiedId", Name = "IX_DRE_CASES_DreNotifiedId")]
[Index("DreRequestedId", Name = "IX_DRE_CASES_DreRequestedId")]
[Index("DreRoleId", Name = "IX_DRE_CASES_DreRoleId")]
[Index("DreTypeId", Name = "IX_DRE_CASES_DreTypeId")]
[Index("StatusId", Name = "IX_DRE_CASES_StatusId")]
public partial class DreCase
{
    [Key]
    [Column("DRECaseId")]
    public int DrecaseId { get; set; }

    public string? UniqueId { get; set; }

    public int DreTypeId { get; set; }

    public int EvaluatorId { get; set; }

    public string DreNumber { get; set; } = null!;

    public string? RollingLogNumber { get; set; }

    public int LocationId { get; set; }

    public int DepartmentId { get; set; }

    public int? DreRoleId { get; set; }

    public bool CrashNone { get; set; }

    public bool CrashFatal { get; set; }

    public bool CrashInjury { get; set; }

    public bool CrashProperty { get; set; }

    public string? AgencyCaseNumber { get; set; }

    public DateTime? EvaulationDate { get; set; }

    public int StatusId { get; set; }

    public int? AssociatedCaseId { get; set; }

    public DateTime? ActualTime { get; set; }

    public DateTime? DefendantTime { get; set; }

    public bool? DiabeticEpileptic { get; set; }

    [StringLength(30)]
    public string? DiabeticEpilepticDesc { get; set; }

    public int? DreNotifiedId { get; set; }

    public int? DreRequestedId { get; set; }

    [StringLength(50)]
    public string? DrinkingHowMuch { get; set; }

    [StringLength(30)]
    public string? DrinkingTime { get; set; }

    [StringLength(200)]
    public string? DrinkingToday { get; set; }

    [StringLength(500)]
    public string? EatenToday { get; set; }

    [StringLength(50)]
    public string? EatenWhen { get; set; }

    [StringLength(200)]
    public string? EvaluationAddress { get; set; }

    public int? InitialAngleNystagums { get; set; }

    public string? InitialObservationOfSubject { get; set; }

    [StringLength(3)]
    public string? InitialPupilSizeL { get; set; }

    [StringLength(3)]
    public string? InitialPupilSizeR { get; set; }

    public bool? Insulin { get; set; }

    [StringLength(30)]
    public string? InsulinDesc { get; set; }

    [StringLength(50)]
    public string? LastSleep { get; set; }

    public bool? MedicationsDrug { get; set; }

    [StringLength(50)]
    public string? MedicationsDrugDesc { get; set; }

    public bool? MirandaEnglish { get; set; }

    public bool? MirandaGiven { get; set; }

    public bool? MirandaSpanish { get; set; }

    public DateTime? NotifyDate { get; set; }

    public DateTime? NotifyTime { get; set; }

    [StringLength(100)]
    public string? OffenseAddress1 { get; set; }

    [StringLength(100)]
    public string? OffenseAddress2 { get; set; }

    [StringLength(50)]
    public string? OffenseCity { get; set; }

    public int? OffenseCounty { get; set; }

    public int? OffenseState { get; set; }

    [StringLength(10)]
    public string? OffenseZip { get; set; }

    public bool? PhysicalDefects { get; set; }

    [StringLength(50)]
    public string? PhysicalDefectsDesc { get; set; }

    [StringLength(30)]
    public string? PulseRate1 { get; set; }

    [StringLength(30)]
    public string? PulseRate2 { get; set; }

    [StringLength(30)]
    public string? PulseRate3 { get; set; }

    [StringLength(30)]
    public string? PulseSite1 { get; set; }

    [StringLength(30)]
    public string? PulseSite2 { get; set; }

    [StringLength(30)]
    public string? PulseSite3 { get; set; }

    public DateTime? PulseTime1 { get; set; }

    public DateTime? PulseTime2 { get; set; }

    public DateTime? PulseTime3 { get; set; }

    public bool? SickInjured { get; set; }

    [StringLength(30)]
    public string? SickInjuredDesc { get; set; }

    [StringLength(30)]
    public string? SleepHowLong { get; set; }

    public bool? UnderCare { get; set; }

    [StringLength(50)]
    public string? UnderCareDesc { get; set; }

    public DateTime? MirandaDate { get; set; }

    [StringLength(50)]
    public string? MirandaGivenBy { get; set; }

    public bool? MirandaUnderstood { get; set; }

    public double? OffenseLat { get; set; }

    public double? OffenseLng { get; set; }

    public string? CaseOwnerAgency { get; set; }

    public string? CaseOwnerBadge { get; set; }

    public int CaseOwnerDepartmentId { get; set; }

    public string? CaseOwnerId { get; set; }

    public string? CaseOwnerName { get; set; }

    public string? CaseOwnerRank { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCaseAoFst? DreCaseAoFst { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCaseAoInterview? DreCaseAoInterview { get; set; }

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseHgn> DreCaseHgns { get; set; } = new List<DreCaseHgn>();

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseImage> DreCaseImages { get; set; } = new List<DreCaseImage>();

    [InverseProperty("DreCase")]
    public virtual DreCaseIndicator? DreCaseIndicator { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCaseIntoxilyzerReport? DreCaseIntoxilyzerReport { get; set; }

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseNote> DreCaseNotes { get; set; } = new List<DreCaseNote>();

    [InverseProperty("DreCase")]
    public virtual DreCaseOls? DreCaseOl { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCaseOtherObservation? DreCaseOtherObservation { get; set; }

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCasePic> DreCasePics { get; set; } = new List<DreCasePic>();

    [InverseProperty("DreCase")]
    public virtual DreCaseRb? DreCaseRb { get; set; }

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseToxSpec> DreCaseToxSpecs { get; set; } = new List<DreCaseToxSpec>();

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseToxicologyDrug> DreCaseToxicologyDrugs { get; set; } = new List<DreCaseToxicologyDrug>();

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCaseVideo> DreCaseVideos { get; set; } = new List<DreCaseVideo>();

    [InverseProperty("DreCase")]
    public virtual DreCaseWt? DreCaseWt { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCasesAoObs? DreCasesAoOb { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCasesDarkRoom? DreCasesDarkRoom { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCasesFtn? DreCasesFtn { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCasesObs? DreCasesOb { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreCasesOffense? DreCasesOffense { get; set; }

    [InverseProperty("DreCase")]
    public virtual ICollection<DreCasesOtherOfficer> DreCasesOtherOfficers { get; set; } = new List<DreCasesOtherOfficer>();

    [InverseProperty("DreCase")]
    public virtual DreCasesVitalSign? DreCasesVitalSign { get; set; }

    [InverseProperty("DreCase")]
    public virtual DreDefendant? DreDefendant { get; set; }

    [ForeignKey("DreNotifiedId")]
    [InverseProperty("DreCases")]
    public virtual TblOptDreNotified? DreNotified { get; set; }

    [ForeignKey("DreRequestedId")]
    [InverseProperty("DreCases")]
    public virtual TblOptDreRequested? DreRequested { get; set; }

    [ForeignKey("DreRoleId")]
    [InverseProperty("DreCases")]
    public virtual TblOptDreRole? DreRole { get; set; }

    [ForeignKey("DreTypeId")]
    [InverseProperty("DreCases")]
    public virtual TblOptDreType DreType { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("DreCases")]
    public virtual TblOptDreCaseStatus Status { get; set; } = null!;
}
