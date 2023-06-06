using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Transport_Mode", Schema = "DUI")]
public partial class TblOptNcicTransportMode
{
    [Key]
    public int NcicTransportModeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(250)]
    public string? Comments { get; set; }

    public bool Active { get; set; }

    public int? ModeId { get; set; }

    [InverseProperty("NcicTransportMode")]
    public virtual ICollection<TblOptSystemMode> TblOptSystemModes { get; set; } = new List<TblOptSystemMode>();
}
