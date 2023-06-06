using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES_VITAL_SIGNS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_VITAL_SIGNS_DreCaseId", IsUnique = true)]
public partial class DreCasesVitalSign
{
    [Key]
    public int DreCaseVitalSignId { get; set; }

    public int DreCaseId { get; set; }

    [StringLength(30)]
    public string? PulseRate { get; set; }

    public DateTime? PulseTime { get; set; }

    [StringLength(30)]
    public string? PulseSite { get; set; }

    [Column("BPSystolic")]
    [StringLength(20)]
    public string? Bpsystolic { get; set; }

    [Column("BPDiastolic")]
    [StringLength(20)]
    public string? Bpdiastolic { get; set; }

    [StringLength(10)]
    public string? Temperature { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasesVitalSign")]
    public virtual DreCase DreCase { get; set; } = null!;
}
