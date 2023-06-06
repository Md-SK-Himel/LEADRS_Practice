using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SystemPages", Schema = "DUI")]
public partial class SystemPage
{
    [Key]
    public int SystemPageId { get; set; }

    public string? Title { get; set; }

    public string? PageName { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    [InverseProperty("DuiCasePage")]
    public virtual ICollection<DuiCaseNoteType> DuiCaseNoteTypes { get; set; } = new List<DuiCaseNoteType>();

    [InverseProperty("Page")]
    public virtual ICollection<SystemModeControl> SystemModeControls { get; set; } = new List<SystemModeControl>();
}
