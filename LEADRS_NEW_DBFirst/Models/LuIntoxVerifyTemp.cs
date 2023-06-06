using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_IntoxVerifyTemp")]
public partial class LuIntoxVerifyTemp
{
    [Key]
    public int VerifyTempId { get; set; }

    [StringLength(50)]
    public string VerifyTemp { get; set; } = null!;

    public bool Active { get; set; }
}
