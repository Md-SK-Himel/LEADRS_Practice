using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Keyless]
public partial class AvGetCboNcicVehicleModel
{
    public int NcicVehicleModelId { get; set; }

    public int MakeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    [StringLength(250)]
    public string? OrigDescription { get; set; }

    public int Active { get; set; }
}
