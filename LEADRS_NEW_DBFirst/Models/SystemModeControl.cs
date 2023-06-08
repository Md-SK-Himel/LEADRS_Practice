using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SystemModeControls", Schema = "DUI")]
[Index("ModeId", Name = "IX_SystemModeControls_ModeId")]
[Index("PageId", Name = "IX_SystemModeControls_PageId")]
public partial class SystemModeControl
{
    [Key]
    public int SystemModeControlId { get; set; }

    public int? ModeId { get; set; }

    public int? PageId { get; set; }

    public string? ControlName { get; set; }

    public string? Label { get; set; }

    public bool Visible { get; set; }

    public bool Required { get; set; }

    public bool Enabled { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    [ForeignKey("ModeId")]
    [InverseProperty("SystemModeControls")]
    public virtual TblOptSystemMode? Mode { get; set; }

    [ForeignKey("PageId")]
    [InverseProperty("SystemModeControls")]
    public virtual SystemPage? Page { get; set; }
}
