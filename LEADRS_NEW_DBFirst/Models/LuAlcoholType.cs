using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_AlcoholType")]
public partial class LuAlcoholType
{
    [Key]
    public int AlcoholTypeId { get; set; }

    [StringLength(100)]
    public string Alcohol { get; set; } = null!;

    public bool Active { get; set; }
}
