using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_SexualOrBias")]
public partial class LuSexualOrBias
{
    [Key]
    public int SexualOrBiasId { get; set; }

    [StringLength(100)]
    public string SexualOrBiasName { get; set; } = null!;

    public bool Active { get; set; }
}
