using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_ReligionBias")]
public partial class LuReligionBias
{
    [Key]
    public int ReligionBiasId { get; set; }

    [StringLength(100)]
    public string? ReligionBiasName { get; set; }

    public bool Active { get; set; }
}
