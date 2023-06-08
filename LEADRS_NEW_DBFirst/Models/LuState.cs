using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_States")]
public partial class LuState
{
    [Key]
    public int StateId { get; set; }

    [StringLength(250)]
    public string Method { get; set; } = null!;

    [StringLength(10)]
    public string Abbreviation { get; set; } = null!;

    public bool Active { get; set; }
}
