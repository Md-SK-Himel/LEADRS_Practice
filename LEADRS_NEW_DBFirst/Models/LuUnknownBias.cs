using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_UnknownBias")]
public partial class LuUnknownBias
{
    [Key]
    public int UnknownBiasId { get; set; }

    [StringLength(100)]
    public string? UnknownBiasName { get; set; }

    public bool Active { get; set; }
}
