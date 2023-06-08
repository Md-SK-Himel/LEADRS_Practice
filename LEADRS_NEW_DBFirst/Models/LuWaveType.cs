using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_WaveTypes")]
public partial class LuWaveType
{
    [Key]
    public int WaveTypeId { get; set; }

    [StringLength(250)]
    public string WaveType { get; set; } = null!;

    public bool Active { get; set; }
}
