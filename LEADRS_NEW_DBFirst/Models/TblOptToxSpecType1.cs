using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Tox_Spec_Types", Schema = "DUI")]
public partial class TblOptToxSpecType1
{
    [Key]
    public int ToxSpecTypeId { get; set; }

    [StringLength(50)]
    public string? ToxSpecTypeDesc { get; set; }

    public bool Active { get; set; }
}
