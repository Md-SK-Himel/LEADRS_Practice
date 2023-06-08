using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_BodyWaters", Schema = "DUI")]
public partial class TblOptBodyWater
{
    [Key]
    public int BodyOfWaterId { get; set; }

    [StringLength(10)]
    public string? Code { get; set; }

    [StringLength(250)]
    public string? BodyOfWaterDesc { get; set; }

    public bool Active { get; set; }
}
