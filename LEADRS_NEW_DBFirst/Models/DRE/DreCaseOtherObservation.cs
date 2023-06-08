using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_Case_OtherObservation", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_Case_OtherObservation_DreCaseId", IsUnique = true)]
public class DreCaseOtherObservation : EntityAbstraction
{
    [Key]
    public int OtherObservationId { get; set; }
    
    public bool? MtNormal { get; set; }
    public bool? MtFlaccid { get; set; }
    public bool? MtRigid { get; set; }
    [MaxLength(50)]
    public string MtComments { get; set; }
    public int? InjectionSitesId { get; set; }
    [MaxLength(100)]
    public string InjRaText { get; set; }
    [MaxLength(100)]
    public string InjLaText { get; set; }
    [MaxLength(2000)]
    public string InjComments { get; set; }
    [MaxLength(30)]
    public string PulseRate3 { get; set; }
    public DateTime? PulseTime3 { get; set; }
    [MaxLength(30)]
    public string PulseSite3 { get; set; }
    [MaxLength(100)]
    public string SubDrugs { get; set; }
    [MaxLength(50)]
    public string SubDrugsQty { get; set; }
    [MaxLength(50)]
    public string SubDrugsTime { get; set; }
    [MaxLength(50)]
    public string SubDrugsWhere { get; set; }
    [MaxLength(2000)]
    public string SubOtherComments { get; set; }
    public DateTime? EvalCompletionTime { get; set; }
    public bool SubRefusedEval { get; set; }
    public bool SubStopPartEval { get; set; }
}
