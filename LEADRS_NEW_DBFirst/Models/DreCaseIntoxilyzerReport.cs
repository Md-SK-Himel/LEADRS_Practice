using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_INTOXILYZER_REPORT", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_INTOXILYZER_REPORT_DreCaseId", IsUnique = true)]
public partial class DreCaseIntoxilyzerReport
{
    [Key]
    public int DreCaseIntoxilyzerReportId { get; set; }

    public int DreCaseId { get; set; }

    public bool? ProvidedBreath { get; set; }

    public bool? ProvidedBlood { get; set; }

    public bool? ProvidedUrine { get; set; }

    public bool? ProvidedSaliva { get; set; }

    public bool? AttemptedBreath { get; set; }

    public bool? AttemptedBlood { get; set; }

    public bool? AttemptedUrine { get; set; }

    public bool? AttemptedSaliva { get; set; }

    public bool? RefusedBreath { get; set; }

    public bool? RefusedBlood { get; set; }

    public bool? RefusedUrine { get; set; }

    public bool? RefusedSaliva { get; set; }

    public bool? BloodTaken { get; set; }

    public DateTime? BreathDateGiven { get; set; }

    public DateTime? BreathBeginWait { get; set; }

    public int? BreathVerifytempId { get; set; }

    [StringLength(2000)]
    public string? BreathSubjectComments { get; set; }

    public bool? BreathIntoxOperatorL5 { get; set; }

    [StringLength(255)]
    public string? BreathOperatorName { get; set; }

    [StringLength(150)]
    public string? BreathOperatorAgency { get; set; }

    [StringLength(255)]
    public string? BreathRecordNumber { get; set; }

    [StringLength(255)]
    public string? BreathSerialNumber { get; set; }

    [StringLength(255)]
    public string? BreathResult1 { get; set; }

    public DateTime? BreathResult1Time { get; set; }

    [StringLength(10)]
    public string? BreathResult2 { get; set; }

    public DateTime? BreathResult2Time { get; set; }

    public int? BreathMoreLessIntoxIdL5 { get; set; }

    [StringLength(10)]
    public string? BloodVials { get; set; }

    [StringLength(255)]
    public string? BloodNamePwd { get; set; }

    [StringLength(255)]
    public string? BloodEmployerPwd { get; set; }

    public int? BloodEmployedIdPwd { get; set; }

    [StringLength(255)]
    public string? BloodPhonePwd { get; set; }

    [StringLength(500)]
    public string? BloodLocationBwd { get; set; }

    public DateTime? BloodDatetimeSpecimenExtractedBwd { get; set; }

    [StringLength(500)]
    public string? BloodDescriptionBwd { get; set; }

    public int? BloodMoreLessIntoxId { get; set; }

    public bool? BloodPreservative { get; set; }

    public bool? BloodNoAlcohol { get; set; }

    public bool? BloodRotated { get; set; }

    public bool? UrineDreObserved { get; set; }

    [StringLength(255)]
    public string? UrineWhoObserved { get; set; }

    public bool? UrineToxScreenPerformed { get; set; }

    public bool? SalivaDreObserved { get; set; }

    [StringLength(255)]
    public string? SalivaWhoObserved { get; set; }

    public bool? SalivaToxScreenPerformed { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseIntoxilyzerReport")]
    public virtual DreCase DreCase { get; set; } = null!;

    [InverseProperty("DreCaseIntoxilyzerReport")]
    public virtual ICollection<DreCaseIntoxSalivaScreen> DreCaseIntoxSalivaScreens { get; set; } = new List<DreCaseIntoxSalivaScreen>();

    [InverseProperty("DreCaseIntoxilyzerReport")]
    public virtual ICollection<DreCaseIntoxUrineScreen> DreCaseIntoxUrineScreens { get; set; } = new List<DreCaseIntoxUrineScreen>();
}
