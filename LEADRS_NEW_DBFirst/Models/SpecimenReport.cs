using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SpecimenReports", Schema = "DUI")]
[Index("CaseId", Name = "IX_SpecimenReports_CaseId")]
public partial class SpecimenReport
{
    [Key]
    public int SpecimenReportId { get; set; }

    public int CaseId { get; set; }

    [Column("DIC_24_ReadBy")]
    [StringLength(50)]
    public string? Dic24ReadBy { get; set; }

    [Column("DIC_24_Time")]
    public DateTime? Dic24Time { get; set; }

    [Column("DIC_24_ReadEnglish")]
    public bool Dic24ReadEnglish { get; set; }

    [Column("DIC_24_ReadSpanish")]
    public bool Dic24ReadSpanish { get; set; }

    [Column("DIC_24_RecordingUsed")]
    public bool Dic24RecordingUsed { get; set; }

    public bool Breath { get; set; }

    public bool BreathProvided { get; set; }

    public bool BreathRefused { get; set; }

    public bool Blood { get; set; }

    public bool BloodProvided { get; set; }

    public bool BloodRefused { get; set; }

    public bool BloodSpecimenTaken { get; set; }

    public bool Urine { get; set; }

    public bool UrineProvided { get; set; }

    public bool UrinehRefused { get; set; }

    public bool ProvidedNone { get; set; }

    [Column("LabBACResult")]
    [StringLength(50)]
    public string? LabBacresult { get; set; }

    public bool AlchoholDetected { get; set; }

    public bool SearchWarrantSought { get; set; }

    public DateTime? TimePresentedToMagistrate { get; set; }

    [StringLength(50)]
    public string? SearchWarrantfMagistrateName { get; set; }

    [StringLength(50)]
    public string? SearchWarrantCourt { get; set; }

    public bool WarrantIssuedByMagistrate { get; set; }

    public DateTime? MagistrateWarrantTime { get; set; }

    [Column("DLConfiscated")]
    public bool Dlconfiscated { get; set; }

    [Column("DLNotConfiscatedReason")]
    public string? DlnotConfiscatedReason { get; set; }

    [Column("DLNoticeDate")]
    public DateTime? DlnoticeDate { get; set; }

    [Column("Handed_DIC_25")]
    [StringLength(5)]
    public string? HandedDic25 { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("SpecimenReports")]
    public virtual CaseHeader Case { get; set; } = null!;

    [InverseProperty("SpecimenReport")]
    public virtual ICollection<SpecimenBloodTest> SpecimenBloodTests { get; set; } = new List<SpecimenBloodTest>();

    [InverseProperty("SpecimenReport")]
    public virtual ICollection<SpecimenBreathTest> SpecimenBreathTests { get; set; } = new List<SpecimenBreathTest>();

    [InverseProperty("SpecimenReport")]
    public virtual ICollection<SpecimenUrineTest> SpecimenUrineTests { get; set; } = new List<SpecimenUrineTest>();
}
