using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Educations", Schema = "DUI")]
public partial class TblOptEducation
{
    [Key]
    public int EducationId { get; set; }

    [StringLength(100)]
    public string? EducationDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Education")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
}
