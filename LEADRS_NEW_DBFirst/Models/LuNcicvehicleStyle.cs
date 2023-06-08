using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICVehicleStyle")]
public partial class LuNcicvehicleStyle
{
    [Key]
    public int VehicleStyleId { get; set; }

    public int TransportTypeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string? Nciccode { get; set; }

    [StringLength(200)]
    public string? Comments { get; set; }

    public bool Active { get; set; }
}
