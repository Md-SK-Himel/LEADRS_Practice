using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_County")]
public partial class LuCounty
{
    [Key]
    public int CountyId { get; set; }

    [StringLength(2)]
    public string State { get; set; } = null!;

    [StringLength(100)]
    public string CountyName { get; set; } = null!;

    [StringLength(150)]
    public string CountyFullName { get; set; } = null!;

    public bool Active { get; set; }
}
