using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_Status")]
public partial class LuStatus
{
    [Key]
    public int StatusId { get; set; }

    [StringLength(20)]
    public string StatusDescription { get; set; } = null!;

    public bool Active { get; set; }
}
