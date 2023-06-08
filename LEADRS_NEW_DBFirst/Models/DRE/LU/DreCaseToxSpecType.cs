using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_TOX_SPEC_TYPE", Schema = "DRE")]
public class DreCaseToxSpecType
{
    [Key]
    public int ToxSpecTypeId { get; set; }

    [StringLength(255)]
    public string? ToxSpecTypeDesc { get; set; }

    public bool? Active { get; set; }

}
