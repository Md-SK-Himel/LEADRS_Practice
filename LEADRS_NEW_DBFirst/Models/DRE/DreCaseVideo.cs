using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_Case_Video", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_Case_Video_DreCaseId")]
public class DreCaseVideo : EntityAbstraction
{
    [Key]
    public int DreCaseVideoId { get; set; }

    public string VideoS3Url { get; set; }
    public string ArchiveId { get; set; }
    public string ApiKey { get; set; }
    public int? Status { get; set; } = 0;
    public string CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
}
