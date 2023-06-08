using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_IMAGES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_IMAGES_DreCaseId")]
public class DreCaseImage : EntityAbstraction
{
    [Key]
    public int DreCaseImageId { get; set; }

    [MaxLength(50)]
    public string ImageName { get; set; }
    public byte[] Image { get; set; }

}
