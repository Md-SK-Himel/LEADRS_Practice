using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_SpecimenStorage")]
public partial class LuSpecimenStorage
{
    [Key]
    public int StorageId { get; set; }

    [StringLength(250)]
    public string Storage { get; set; } = null!;

    public bool Active { get; set; }
}
