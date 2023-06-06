using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_More_Less_Intoxicated", Schema = "DUI")]
public partial class TblOptMoreLessIntoxicated
{
    [Key]
    public int MoreLessIntoxId { get; set; }

    [StringLength(50)]
    public string? MoreLessIntoxDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("MoreLessIntox")]
    public virtual ICollection<SpecimenBloodTest> SpecimenBloodTests { get; set; } = new List<SpecimenBloodTest>();

    [InverseProperty("MoreLessIntox")]
    public virtual ICollection<SpecimenBreathTest> SpecimenBreathTests { get; set; } = new List<SpecimenBreathTest>();

    [InverseProperty("MoreLessIntox")]
    public virtual ICollection<SpecimenUrineTest> SpecimenUrineTests { get; set; } = new List<SpecimenUrineTest>();
}
