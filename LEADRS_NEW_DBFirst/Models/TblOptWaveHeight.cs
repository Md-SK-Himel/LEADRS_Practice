using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Wave_Height", Schema = "DUI")]
public partial class TblOptWaveHeight
{
    [Key]
    public int WaveHeightId { get; set; }

    [StringLength(50)]
    public string? WaveHeightDesc { get; set; }

    public bool Active { get; set; }

    public int? SortOrder { get; set; }
}
