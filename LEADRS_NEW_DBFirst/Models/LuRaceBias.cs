using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_RaceBias")]
public partial class LuRaceBias
{
    [Key]
    public int RaceBiasId { get; set; }

    [StringLength(100)]
    public string RaceBiasName { get; set; } = null!;

    public bool Active { get; set; }
}
