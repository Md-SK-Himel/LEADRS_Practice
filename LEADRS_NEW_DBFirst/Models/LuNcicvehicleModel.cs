using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICVehicleModels")]
public partial class LuNcicvehicleModel
{
    [Key]
    public int VehicleModelId { get; set; }

    public int MakeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string? Nciccode { get; set; }

    [StringLength(250)]
    public string? OrigDescription { get; set; }

    public bool Active { get; set; }
}
