using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_NOTE_TYPES", Schema = "DRE")]
[Index("DreCasePageId", Name = "IX_DRE_CASE_NOTE_TYPES_DreCasePageId")]
public partial class DreCaseNoteType
{
    [Key]
    public int DreCaseNoteTypeId { get; set; }

    public int DreCasePageId { get; set; }

    [StringLength(100)]
    public string? Section { get; set; }

    public bool Active { get; set; }

    public int? FacesheetOrder { get; set; }

    public int? NoteOrder { get; set; }

    [InverseProperty("DreCaseNoteType")]
    public virtual ICollection<DreCaseNote> DreCaseNotes { get; set; } = new List<DreCaseNote>();

    [ForeignKey("DreCasePageId")]
    [InverseProperty("DreCaseNoteTypes")]
    public virtual DreCasePage DreCasePage { get; set; } = null!;
}
