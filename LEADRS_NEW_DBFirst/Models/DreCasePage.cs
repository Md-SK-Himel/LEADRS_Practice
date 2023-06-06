using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_PAGES", Schema = "DRE")]
public partial class DreCasePage
{
    [Key]
    public int DreCasePageId { get; set; }

    [StringLength(50)]
    public string? PageName { get; set; }

    [StringLength(50)]
    public string? Url { get; set; }

    public int PageOrder { get; set; }

    public bool Active { get; set; }

    [InverseProperty("DreCasePage")]
    public virtual ICollection<DreCaseNoteType> DreCaseNoteTypes { get; set; } = new List<DreCaseNoteType>();
}
