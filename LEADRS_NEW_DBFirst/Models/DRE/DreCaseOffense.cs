using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_OFFENSES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_OFFENSES_DreCaseId", IsUnique = true)]
public class DreCaseOffense : EntityAbstraction
{
    [Key]
    public int DreCaseOffenseId { get; set; }


    public bool? Charged { get; set; }

    public bool? DWI { get; set; }
    public int? OffenseId { get; set; }

    public bool? RecklessDriving { get; set; }
    public bool? PublicIntox { get; set; }
    public bool? Theft { get; set; }
    [MaxLength(100)]
    public string TheftCharged { get; set; }
    public bool? Assault { get; set; }
    [MaxLength(100)]
    public string AssaultCharged { get; set; }
    public bool? Possession { get; set; }
    [MaxLength(100)]
    public string PossessionCharged { get; set; }
    public bool? Other { get; set; }
    [MaxLength(100)]
    public string OtherCharged { get; set; }

    public int? CrashId { get; set; }
    public int? InjuryId { get; set; }
    [MaxLength(500)]
    public string NoChargeComment { get; set; }
}
