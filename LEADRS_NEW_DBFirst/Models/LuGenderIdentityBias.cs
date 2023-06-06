using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_GenderIdentityBias")]
public partial class LuGenderIdentityBias
{
    [Key]
    public int GenderIdentityBiasId { get; set; }

    [StringLength(100)]
    public string GenderIdentityBiasName { get; set; } = null!;

    public bool Active { get; set; }
}
