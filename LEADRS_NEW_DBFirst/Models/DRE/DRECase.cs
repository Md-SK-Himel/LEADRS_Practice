﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE.LU;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES", Schema = "DRE")]
[Index("DreNotifiedId", Name = "IX_DRE_CASES_DreNotifiedId")]
[Index("DreRequestedId", Name = "IX_DRE_CASES_DreRequestedId")]
[Index("DreRoleId", Name = "IX_DRE_CASES_DreRoleId")]
[Index("DreTypeId", Name = "IX_DRE_CASES_DreTypeId")]
[Index("StatusId", Name = "IX_DRE_CASES_StatusId")]
public class DRECase
{
    [Key]
    public int DRECaseId { get; set; }

    public string? UniqueId { get; set; } = new Guid().ToString();

    public int? DreTypeId { get; set; }

    public int? EvaluatorId { get; set; }

    public string? DreNumber { get; set; } = null!;

    public string RollingLogNumber { get; set; }

    public int? LocationId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DreRoleId { get; set; }

    public bool? CrashNone { get; set; }

    public bool? CrashFatal { get; set; }

    public bool? CrashInjury { get; set; }

    public bool? CrashProperty { get; set; }

    public string AgencyCaseNumber { get; set; }

    public DateTime? EvaulationDate { get; set; }

    public int? StatusId { get; set; }

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

    [StringLength(50)]
    public string? OffenseLat { get; set; }

    [StringLength(50)]
    public string? OffenseLng { get; set; }

    public string? CaseOwnerAgency { get; set; }

    public string? CaseOwnerBadge { get; set; }

    public int? CaseOwnerDepartmentId { get; set; }

    public string? CaseOwnerId { get; set; }

    public string? CaseOwnerName { get; set; }

    public string? CaseOwnerRank { get; set; }


    #region References

    public DreCaseDarkRoom DarkRoom { get; set; }

    public DreCaseWalkTurn WalkTurn { get; set; }

    public DreCaseVitalSign VitalSign { get; set; }

    public DreCaseDefendant Defendant { get; set; }

    public DreCaseOneLegStand OneLegStand { get; set; }

    public DreCaseObservations CaseObservations { get; set; }

    public DreCaseIntoxilyzerReport IntoxilyzerReport { get; set; }
    
    public DreCaseOtherObservation OtherObservation { get; set; }

    public DreCaseRombergBalance RombergBalance { get; set; }
    
    public DreCaseArrestingOfficerObservation ArrestingOfficerObservation { get; set; }

    public ICollection<DreCaseOtherOfficer> OtherOfficers { get; set; } = new List<DreCaseOtherOfficer>();

    public DreCaseArrestingOfficerInterview ArrestingOfficerInterview { get; set; }

    public ICollection<DreCaseHGN> Hgns { get; set; } = new List<DreCaseHGN>();

    #endregion


    #region ForeignKey

    [ForeignKey("DreNotifiedId")]
    public DreNotified DreNotified { get; set; }

    [ForeignKey("DreRequestedId")]
    public DreRequested DreRequested { get; set; }

    [ForeignKey("DreRoleId")]
    public DRERole DreRole { get; set; }

    [ForeignKey("DreTypeId")]
    public DREType DREType { get; set; } = null!;

    [ForeignKey("StatusId")]
    public DRECaseStatus Status { get; set; } = null!;

    #endregion
}
