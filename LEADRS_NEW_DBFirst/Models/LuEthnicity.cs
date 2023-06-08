using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_Ethnicity")]
public partial class LuEthnicity
{
    [Key]
    public int EthnicityId { get; set; }

    [StringLength(50)]
    public string EthnicityName { get; set; } = null!;

    [Column("NIBRSCode")]
    [StringLength(10)]
    public string? Nibrscode { get; set; }

    public bool Active { get; set; }
}
