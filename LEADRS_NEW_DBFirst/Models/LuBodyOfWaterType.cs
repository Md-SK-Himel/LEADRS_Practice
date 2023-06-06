using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_BodyOfWaterType")]
public partial class LuBodyOfWaterType
{
    [Key]
    public int BodyOfWaterTypeId { get; set; }

    public int Code { get; set; }

    [StringLength(100)]
    public string BodyOfWater { get; set; } = null!;

    public bool Active { get; set; }
}
