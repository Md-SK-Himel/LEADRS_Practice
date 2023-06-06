using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_BWIVesselType")]
public partial class LuBwivesselType
{
    [Key]
    [Column("BWIVesselTypeId")]
    public int BwivesselTypeId { get; set; }

    [Column("BWIVessel")]
    [StringLength(100)]
    public string Bwivessel { get; set; } = null!;

    public bool Active { get; set; }
}
