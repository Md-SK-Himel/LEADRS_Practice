using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Colors", Schema = "DUI")]
public partial class TblOptNcicColor
{
    [Key]
    public int NcicColorId { get; set; }

    [StringLength(25)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("VehicleColor")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();
}
