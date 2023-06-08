using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Vehcile_Style_Types", Schema = "DUI")]
public partial class TblOptNcicVehcileStyleType
{
    [Key]
    public int VehicleStyleId { get; set; }

    public int TransportTypeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    [StringLength(250)]
    public string? Comments { get; set; }

    public bool Active { get; set; }

    [InverseProperty("VehicleStyle")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();
}
