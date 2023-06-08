using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_EducationLevels")]
public partial class LuEducationLevel
{
    [Key]
    public int EducationId { get; set; }

    [StringLength(250)]
    public string EducationDescription { get; set; } = null!;

    public bool Active { get; set; }
}
