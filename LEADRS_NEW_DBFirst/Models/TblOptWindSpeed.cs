using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Wind_Speed", Schema = "DUI")]
public partial class TblOptWindSpeed
{
    [Key]
    public int WindSpeedId { get; set; }

    [StringLength(50)]
    public string? WindSpeedDesc { get; set; }

    public bool Active { get; set; }
}
