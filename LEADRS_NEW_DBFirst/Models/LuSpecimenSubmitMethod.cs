using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_SpecimenSubmitMethod")]
public partial class LuSpecimenSubmitMethod
{
    [Key]
    public int SubmitMethodId { get; set; }

    [StringLength(20)]
    public string Method { get; set; } = null!;

    public bool Active { get; set; }
}
