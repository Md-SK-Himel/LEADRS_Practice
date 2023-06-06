using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_PIC", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_PIC_DreCaseId")]
public partial class DreCasePic
{
    [Key]
    public int DreCasePictureId { get; set; }

    public int DreCaseId { get; set; }

    [StringLength(50)]
    public string? Section { get; set; }

    public int? Sequence { get; set; }

    public byte[]? ImageData { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasePics")]
    public virtual DreCase DreCase { get; set; } = null!;
}
