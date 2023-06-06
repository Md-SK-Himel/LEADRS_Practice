using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_Case_OtherObservation", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_Case_OtherObservation_DreCaseId", IsUnique = true)]
public partial class DreCaseOtherObservation
{
    [Key]
    public int OtherObservationId { get; set; }

    public int DreCaseId { get; set; }

    public bool? MtNormal { get; set; }

    public bool? MtFlaccid { get; set; }

    public bool? MtRigid { get; set; }

    [StringLength(50)]
    public string? MtComments { get; set; }

    public int InjectionSitesId { get; set; }

    [StringLength(100)]
    public string? InjRaText { get; set; }

    [StringLength(100)]
    public string? InjLaText { get; set; }

    [StringLength(2000)]
    public string? InjComments { get; set; }

    [StringLength(30)]
    public string? PulseRate3 { get; set; }

    public DateTime? PulseTime3 { get; set; }

    [StringLength(30)]
    public string? PulseSite3 { get; set; }

    [StringLength(100)]
    public string? SubDrugs { get; set; }

    [StringLength(50)]
    public string? SubDrugsQty { get; set; }

    [StringLength(50)]
    public string? SubDrugsTime { get; set; }

    [StringLength(50)]
    public string? SubDrugsWhere { get; set; }

    [StringLength(2000)]
    public string? SubOtherComments { get; set; }

    public DateTime? EvalCompletionTime { get; set; }

    [StringLength(255)]
    public string? SubRefusedEval { get; set; }

    [StringLength(255)]
    public string? SubStopPartEval { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseOtherObservation")]
    public virtual DreCase DreCase { get; set; } = null!;
}
