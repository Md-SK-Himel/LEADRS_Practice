using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_Race")]
public partial class LuRace
{
    [Key]
    public int RaceId { get; set; }

    [StringLength(50)]
    public string RaceName { get; set; } = null!;

    [Column("NIBRSCode")]
    [StringLength(10)]
    public string? Nibrscode { get; set; }

    public bool Active { get; set; }
}
