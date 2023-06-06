using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Wave_Types", Schema = "DUI")]
public partial class TblOptWaveType
{
    [Key]
    public int WaveTypeId { get; set; }

    [StringLength(50)]
    public string? WaveTypeDesc { get; set; }

    public bool Active { get; set; }
}
