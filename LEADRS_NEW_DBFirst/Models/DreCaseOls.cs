using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_OLS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_OLS_DreCaseId", IsUnique = true)]
public partial class DreCaseOls
{
    [Key]
    [Column("DreCaseOLSId")]
    public int DreCaseOlsid { get; set; }

    public int DreCaseId { get; set; }

    [Column("OLSTimeL")]
    [StringLength(10)]
    public string? OlstimeL { get; set; }

    [Column("OLSTimeR")]
    [StringLength(10)]
    public string? OlstimeR { get; set; }

    [Column("OLSSwaysL")]
    [StringLength(10)]
    public string? OlsswaysL { get; set; }

    [Column("OLSSwaysR")]
    [StringLength(10)]
    public string? OlsswaysR { get; set; }

    [Column("OLSArmsL")]
    [StringLength(10)]
    public string? OlsarmsL { get; set; }

    [Column("OLSArmsR")]
    [StringLength(10)]
    public string? OlsarmsR { get; set; }

    [Column("OLSHoppingL")]
    [StringLength(10)]
    public string? OlshoppingL { get; set; }

    [Column("OLSHoppingR")]
    [StringLength(10)]
    public string? OlshoppingR { get; set; }

    [Column("OLSFootL")]
    public bool? OlsfootL { get; set; }

    [Column("OLSFootR")]
    public bool? OlsfootR { get; set; }

    [Column("OLSLeftDown")]
    [StringLength(1000)]
    public string? OlsleftDown { get; set; }

    [Column("OLSLeftDownCount")]
    public int? OlsleftDownCount { get; set; }

    [Column("OLSRightDown")]
    [StringLength(1000)]
    public string? OlsrightDown { get; set; }

    [Column("OLSRightDownCount")]
    public int? OlsrightDownCount { get; set; }

    public int? FootWearTypeId { get; set; }

    public bool? OneLegStandGiven { get; set; }

    public bool? UnableToPerform { get; set; }

    public bool? UnderstoodInstruction { get; set; }

    public bool? MuscleTensions { get; set; }

    public bool? Sounds { get; set; }

    [Column("OLSNoates")]
    public string? Olsnoates { get; set; }

    [Column("OLSArmTimeL")]
    [StringLength(100)]
    public string? OlsarmTimeL { get; set; }

    [Column("OLSArmTimeR")]
    [StringLength(100)]
    public string? OlsarmTimeR { get; set; }

    [Column("OLSSwayTimeL")]
    [StringLength(100)]
    public string? OlsswayTimeL { get; set; }

    [Column("OLSSwayTimeR")]
    [StringLength(100)]
    public string? OlsswayTimeR { get; set; }

    [Column("OLSHopTimeL")]
    [StringLength(100)]
    public string? OlshopTimeL { get; set; }

    [Column("OLSHopTimeR")]
    [StringLength(100)]
    public string? OlshopTimeR { get; set; }

    [Column("OLSTImeLeftDown")]
    [StringLength(1000)]
    public string? OlstimeLeftDown { get; set; }

    [Column("OLSTImeRightDown")]
    [StringLength(1000)]
    public string? OlstimeRightDown { get; set; }

    [Column("NOLookDownL")]
    public bool? NolookDownL { get; set; }

    [Column("NOLookDownR")]
    public bool? NolookDownR { get; set; }

    public bool? NoCountL { get; set; }

    public bool? NoCountR { get; set; }

    public bool? NotSixInchesL { get; set; }

    public bool? NotSixInchesR { get; set; }

    public bool? BodyTremosL { get; set; }

    public bool? EyeLidTremosL { get; set; }

    public bool? LegTremosL { get; set; }

    public bool? OtherL { get; set; }

    [Column("OLSOtherL")]
    [StringLength(2000)]
    public string? OlsotherL { get; set; }

    [Column("BodyTremos_R")]
    public bool? BodyTremosR { get; set; }

    public bool? EyeLidTremosR { get; set; }

    public bool? LegTremosR { get; set; }

    public bool? OtherR { get; set; }

    [Column("OLSOtherR")]
    [StringLength(2000)]
    public string? OlsotherR { get; set; }

    [Column("OLSComments")]
    [StringLength(4000)]
    public string? Olscomments { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseOl")]
    public virtual DreCase DreCase { get; set; } = null!;
}
