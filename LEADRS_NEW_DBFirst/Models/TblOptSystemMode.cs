using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_System_Mode", Schema = "DUI")]
[Index("NcicTransportModeId", Name = "IX_TBL_OPT_System_Mode_NcicTransportModeId")]
[Index("OffenseTypeId", Name = "IX_TBL_OPT_System_Mode_OffenseTypeId")]
public partial class TblOptSystemMode
{
    [Key]
    public int ModeId { get; set; }

    public string? ModeName { get; set; }

    public int ModeOrder { get; set; }

    public int? OffenseTypeId { get; set; }

    public bool Active { get; set; }

    public int? NcicTransportModeId { get; set; }

    [InverseProperty("Mode")]
    public virtual ICollection<CaseHeader> CaseHeaders { get; set; } = new List<CaseHeader>();

    [ForeignKey("NcicTransportModeId")]
    [InverseProperty("TblOptSystemModes")]
    public virtual TblOptNcicTransportMode? NcicTransportMode { get; set; }

    [ForeignKey("OffenseTypeId")]
    [InverseProperty("TblOptSystemModes")]
    public virtual TblOptOffenseType? OffenseType { get; set; }

    [InverseProperty("Mode")]
    public virtual ICollection<SystemModeControl> SystemModeControls { get; set; } = new List<SystemModeControl>();
}
