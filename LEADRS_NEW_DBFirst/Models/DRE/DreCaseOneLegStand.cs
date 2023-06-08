using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_OLS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_OLS_DreCaseId", IsUnique = true)]
public class DreCaseOneLegStand : EntityAbstraction
{
    [Key]
    public int DreCaseOLSId { get; set; }

    [MaxLength(10)]
    public string OLSTimeL { get; set; }
    [MaxLength(10)]
    public string OLSTimeR { get; set; }
    [MaxLength(10)]
    public string OLSSwaysL { get; set; }
    [MaxLength(10)]
    public string OLSSwaysR { get; set; }
    [MaxLength(10)]
    public string OLSArmsL { get; set; }
    [MaxLength(10)]
    public string OLSArmsR { get; set; }
    [MaxLength(10)]
    public string OLSHoppingL { get; set; }
    [MaxLength(10)]
    public string OLSHoppingR { get; set; }
    public bool? OLSFootL { get; set; }
    public bool? OLSFootR { get; set; }
    [MaxLength(1000)]
    public string OLSLeftDown { get; set; }
    public int? OLSLeftDownCount { get; set; }
    [MaxLength(1000)]
    public string OLSRightDown { get; set; }
    public int? OLSRightDownCount { get; set; }

    public int? FootWearTypeId { get; set; }

    public bool? OneLegStandGiven { get; set; }
    public bool? UnableToPerform { get; set; }
    public bool? UnderstoodInstruction { get; set; }
    public bool? MuscleTensions { get; set; }
    public bool? Sounds { get; set; }
    public string OLSNoates { get; set; }
    [MaxLength(100)]
    public string OLSArmTimeL { get; set; }
    [MaxLength(100)]
    public string OLSArmTimeR { get; set; }
    [MaxLength(100)]
    public string OLSSwayTimeL { get; set; }
    [MaxLength(100)]
    public string OLSSwayTimeR { get; set; }
    [MaxLength(100)]
    public string OLSHopTimeL { get; set; }
    [MaxLength(100)]
    public string OLSHopTimeR { get; set; }
    [MaxLength(1000)]
    public string OLSTImeLeftDown { get; set; }
    [MaxLength(1000)]
    public string OLSTImeRightDown { get; set; }
    public bool? NOLookDownL { get; set; }
    public bool? NOLookDownR { get; set; }
    public bool? NoCountL { get; set; }
    public bool? NoCountR { get; set; }
    public bool? NotSixInchesL { get; set; }
    public bool? NotSixInchesR { get; set; }
    public bool? BodyTremosL { get; set; }
    public bool? EyeLidTremosL { get; set; }
    public bool? LegTremosL { get; set; }
    public bool? OtherL { get; set; }
    [MaxLength(2000)]
    public string OLSOtherL { get; set; }
    public bool? BodyTremos_R { get; set; }
    public bool? EyeLidTremosR { get; set; }
    public bool? LegTremosR { get; set; }
    public bool? OtherR { get; set; }
    [MaxLength(2000)]
    public string OLSOtherR { get; set; }
    [MaxLength(4000)]
    public string OLSComments { get; set; }
}
