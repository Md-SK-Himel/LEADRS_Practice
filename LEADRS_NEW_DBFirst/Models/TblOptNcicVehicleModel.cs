using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Vehicle_Model", Schema = "DUI")]
public partial class TblOptNcicVehicleModel
{
    [Key]
    public int NcicVehicleModelId { get; set; }

    public int MakeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    [StringLength(250)]
    public string? OrigDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("VehicleModel")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();
}
