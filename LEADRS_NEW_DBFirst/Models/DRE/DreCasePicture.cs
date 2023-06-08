using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_PIC", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_PIC_DreCaseId")]
public class DreCasePicture : EntityAbstraction
{
    [Key]
    public int DreCasePictureId { get; set; }
    [MaxLength(50)]
    public string Section { get; set; }
    public int? Sequence { get; set; }
    public byte[] ImageData { get; set; }
}
