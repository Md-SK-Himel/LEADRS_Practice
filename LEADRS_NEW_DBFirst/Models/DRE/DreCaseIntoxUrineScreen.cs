using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_INTOX_URINE_SCREEN", Schema = "DRE")]
[Index("DreCaseIntoxilyzerReportId", Name = "IX_DRE_CASE_INTOX_URINE_SCREEN_DreCaseIntoxilyzerReportId")]
public class DreCaseIntoxUrineScreen
{
    [Key]
    public int DreUrineToxResultId { get; set; }
    public int DreCaseIntoxilyzerReportId { get; set; }
    public int ToxScreenResultId { get; set; }

    [MaxLength(100)]
    public string Comment { get; set; }

    [ForeignKey("DreCaseIntoxilyzerReportId")]
    public DreCaseIntoxilyzerReport DreCaseIntoxilyzerReport { get; set; }
}
