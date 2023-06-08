using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_PAGES", Schema = "DRE")]
public class DreCasePage
{
    [Key]
    public int DreCasePageId { get; set; }
    [MaxLength(50)]
    public string PageName { get; set; }
    [MaxLength(50)]
    public string Url { get; set; }
    public int PageOrder { get; set; }
    public bool? Active { get; set; }

    public virtual ICollection<DreCaseNoteType> DreCaseNoteTypes { get; set; } = new List<DreCaseNoteType>();
}
