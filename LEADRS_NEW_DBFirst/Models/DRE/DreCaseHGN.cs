using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_HGN", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_HGN_DreCaseId")]
public class DreCaseHGN : EntityAbstraction
{
    [Key]
    public int DreCaseHgnId { get; set; }

    [StringLength(4)]
    public string CluesLeft { get; set; }

    [StringLength(4)]
    public string CluesRight { get; set; }

    [StringLength(4)]
    public string CluesTotal { get; set; }
    public bool? HeadInjuries { get; set; }

    [StringLength(2000)]
    public string HeadInjuriesComments { get; set; }
    public bool? Contacts { get; set; }

    [StringLength(2000)]
    public string ContactDescription { get; set; }
    public bool? EqualPupilSize { get; set; }

    [StringLength(2000)]
    public string PupilSizeComments { get; set; }
    public bool? RestingNystagmus { get; set; }
    public bool? EqualTracking { get; set; }
    public bool? FollowStimulus { get; set; }

    [StringLength(2000)]
    public string StimulusComments { get; set; }
    public bool? LackOfPursuitL { get; set; }
    public bool? LackOfPursuitR { get; set; }
    public bool? DistinctMaxDevL { get; set; }
    public bool? DistinctMaxDevR { get; set; }
    public bool? OnsetPrior45L { get; set; }
    public bool? OnsetPrior45R { get; set; }
    public bool? IsVerticalNyst { get; set; }

    [StringLength(2000)]
    public string OtherComments { get; set; }
    public bool? HgnUnderstood { get; set; }
    public bool? VerticalNyst { get; set; }
    public int? HgnEstimatedAngleId { get; set; }
    public int? LEstimatedAngleId { get; set; }
    public int? REstimatedAngleId { get; set; }

    public bool? ConvergencePresent { get; set; }
}
