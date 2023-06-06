using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_NOTES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_NOTES_DreCaseId")]
[Index("DreCaseNoteTypeId", Name = "IX_DRE_CASE_NOTES_DreCaseNoteTypeId")]
public partial class DreCaseNote
{
    [Key]
    public int DreCaseNoteId { get; set; }

    public int DreCaseId { get; set; }

    public int DreCaseNoteTypeId { get; set; }

    public string? Notes { get; set; }

    public string? CreatedById { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ParentId { get; set; }

    public string? UpdatedById { get; set; }

    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseNotes")]
    public virtual DreCase DreCase { get; set; } = null!;

    [ForeignKey("DreCaseNoteTypeId")]
    [InverseProperty("DreCaseNotes")]
    public virtual DreCaseNoteType DreCaseNoteType { get; set; } = null!;
}
