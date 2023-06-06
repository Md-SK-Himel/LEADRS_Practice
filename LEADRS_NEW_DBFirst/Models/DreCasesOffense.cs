using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES_OFFENSES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_OFFENSES_DreCaseId", IsUnique = true)]
public partial class DreCasesOffense
{
    [Key]
    public int DreCaseOffenseId { get; set; }

    public int DreCaseId { get; set; }

    public bool? Charged { get; set; }

    [Column("DWI")]
    public bool? Dwi { get; set; }

    public int? OffenseId { get; set; }

    public bool? RecklessDriving { get; set; }

    public bool? PublicIntox { get; set; }

    public bool? Theft { get; set; }

    [StringLength(100)]
    public string? TheftCharged { get; set; }

    public bool? Assault { get; set; }

    [StringLength(100)]
    public string? AssaultCharged { get; set; }

    public bool? Possession { get; set; }

    [StringLength(100)]
    public string? PossessionCharged { get; set; }

    public bool? Other { get; set; }

    [StringLength(100)]
    public string? OtherCharged { get; set; }

    public int? CrashId { get; set; }

    public int? InjuryId { get; set; }

    [StringLength(500)]
    public string? NoChargeComment { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasesOffense")]
    public virtual DreCase DreCase { get; set; } = null!;
}
