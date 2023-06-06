using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_DisabilityBias")]
public partial class LuDisabilityBias
{
    [Key]
    public int DisabilityBiasId { get; set; }

    [StringLength(100)]
    public string DisabilityBiasName { get; set; } = null!;

    public bool Active { get; set; }
}
