using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Transport_Type", Schema = "DUI")]
public partial class TblOptNcicTransportType
{
    [Key]
    public int NcicTransportTypeId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public bool Active { get; set; }

    [InverseProperty("VehicleType")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();
}
