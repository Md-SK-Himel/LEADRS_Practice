using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_VITAL_SIGNS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_VITAL_SIGNS_DreCaseId", IsUnique = true)]
public class DreCaseVitalSign : EntityAbstraction
{
    [Key]
    public int DreCaseVitalSignId { get; set; }

    [MaxLength(30)]
    public string PulseRate { get; set; }
    public DateTime? PulseTime { get; set; }
    [MaxLength(30)]
    public string PulseSite { get; set; }

    [MaxLength(20)]
    public string BPSystolic { get; set; }

    [MaxLength(20)]
    public string BPDiastolic { get; set; }


    [MaxLength(10)]
    public string Temperature { get; set; }
}
