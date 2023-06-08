using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DUI_CASE_NOTES", Schema = "DUI")]
[Index("DuiCaseId", Name = "IX_DUI_CASE_NOTES_DuiCaseId")]
[Index("DuiCaseNoteTypeId", Name = "IX_DUI_CASE_NOTES_DuiCaseNoteTypeId")]
public partial class DuiCaseNote
{
    [Key]
    public int DuiCaseNoteId { get; set; }

    public int DuiCaseId { get; set; }

    public int DuiCaseNoteTypeId { get; set; }

    public string? Notes { get; set; }

    public int? ParentId { get; set; }

    public string? CreatedById { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedById { get; set; }

    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("DuiCaseId")]
    [InverseProperty("DuiCaseNotes")]
    public virtual CaseHeader DuiCase { get; set; } = null!;
}
