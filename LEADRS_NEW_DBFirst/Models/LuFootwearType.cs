using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_FootwearType")]
public partial class LuFootwearType
{
    [Key]
    public int FootwearId { get; set; }

    [StringLength(100)]
    public string FootwearDescription { get; set; } = null!;

    public bool Active { get; set; }
}
