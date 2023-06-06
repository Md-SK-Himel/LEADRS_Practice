using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_Case_Video", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_Case_Video_DreCaseId")]
public partial class DreCaseVideo
{
    [Key]
    public int DreCaseVideoId { get; set; }

    public int DreCaseId { get; set; }

    [Column("VideoS3Url")]
    public string? VideoS3url { get; set; }

    public string? ArchiveId { get; set; }

    public string? ApiKey { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int Status { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseVideos")]
    public virtual DreCase DreCase { get; set; } = null!;
}
