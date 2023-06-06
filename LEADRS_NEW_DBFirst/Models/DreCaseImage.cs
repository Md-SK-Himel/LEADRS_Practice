using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_IMAGES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_IMAGES_DreCaseId")]
public partial class DreCaseImage
{
    [Key]
    public int DreCaseImageId { get; set; }

    public int DreCaseId { get; set; }

    [StringLength(50)]
    public string? ImageName { get; set; }

    public byte[]? Image { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseImages")]
    public virtual DreCase DreCase { get; set; } = null!;
}
