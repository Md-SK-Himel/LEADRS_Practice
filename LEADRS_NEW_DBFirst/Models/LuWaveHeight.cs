using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_WaveHeights")]
public partial class LuWaveHeight
{
    [Key]
    public int WaveHeightId { get; set; }

    [StringLength(250)]
    public string WaveHeight { get; set; } = null!;

    public int SortOrder { get; set; }

    public bool Active { get; set; }
}
