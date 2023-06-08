using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_HairColor")]
public partial class LuHairColor
{
    [Key]
    public int HairColorId { get; set; }

    [StringLength(50)]
    public string HairColorName { get; set; } = null!;

    public bool Active { get; set; }
}
