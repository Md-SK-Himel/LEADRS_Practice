using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DUI_CASE_NOTE_TYPES", Schema = "DUI")]
[Index("DuiCasePageId", Name = "IX_DUI_CASE_NOTE_TYPES_DuiCasePageId")]
public partial class DuiCaseNoteType
{
    [Key]
    public int DuiCaseNoteTypeId { get; set; }

    public int DuiCasePageId { get; set; }

    [StringLength(100)]
    public string? Section { get; set; }

    public bool Active { get; set; }

    public int NoteOrder { get; set; }

    [ForeignKey("DuiCasePageId")]
    [InverseProperty("DuiCaseNoteTypes")]
    public virtual SystemPage DuiCasePage { get; set; } = null!;
}
