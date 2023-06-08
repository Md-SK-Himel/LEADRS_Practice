using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_GenderBias")]
public partial class LuGenderBias
{
    [Key]
    public int GenderBiasId { get; set; }

    [StringLength(100)]
    public string GenderBiasName { get; set; } = null!;

    public bool Active { get; set; }
}
