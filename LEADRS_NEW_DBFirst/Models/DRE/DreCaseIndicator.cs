using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_INDICATORS", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_INDICATORS_DreCaseId", IsUnique = true)]
public class DreCaseIndicator : EntityAbstraction
{
    [Key]
    public int DreCaseIndicatorId { get; set; }
    [MaxLength(500)]
    public string HgnInd { get; set; }
    [MaxLength(500)]
    public string VgnInd { get; set; }
    [MaxLength(500)]
    public string LocInd { get; set; }
    [MaxLength(500)]
    public string PsInd { get; set; }
    [MaxLength(500)]
    public string RtlInd { get; set; }
    [MaxLength(500)]
    public string PrInd { get; set; }
    [MaxLength(500)]
    public string BpInd { get; set; }
    [MaxLength(500)]
    public string BtInd { get; set; }
    [MaxLength(500)]
    public string MstInd { get; set; }

    public bool? OpNotImpaired { get; set; }
    public bool? OpAlcohol { get; set; }
    public bool? OpCnsStimulant { get; set; }
    public bool? OpDissAnesthetic { get; set; }
    public bool? OpInhalant { get; set; }
    public bool? OpMedical { get; set; }
    public bool? OpCnsDepressant { get; set; }
    public bool? OpHallucinogen { get; set; }
    public bool? OpNarcoticAnalgesic { get; set; }
    public bool? OpCannabis { get; set; }
    [MaxLength(255)]
    public string CnsDep { get; set; }
    [MaxLength(255)]
    public string HallBody { get; set; }
    [MaxLength(255)]
    public string CnsSti { get; set; }
    [MaxLength(255)]
    public string DissAne { get; set; }
    [MaxLength(255)]
    public string NarAna { get; set; }
    [MaxLength(255)]
    public string Inha { get; set; }
    [MaxLength(255)]
    public string Cann { get; set; }
}
