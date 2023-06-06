using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_SpecimenSubmittedMethod", Schema = "DUI")]
public partial class TblOptSpecimenSubmittedMethod
{
    [Key]
    public int SpecimenSubmittedMethodId { get; set; }

    [StringLength(50)]
    public string? Method { get; set; }

    public bool Active { get; set; }
}
