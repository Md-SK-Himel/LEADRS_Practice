using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_TOX_SPEC_TYPE", Schema = "DRE")]
public partial class TblOptToxSpecType
{
    [Key]
    public int ToxSpecTypeId { get; set; }

    [StringLength(255)]
    public string? ToxSpecTypeDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("ToxSpecType")]
    public virtual ICollection<DreCaseToxSpec> DreCaseToxSpecs { get; set; } = new List<DreCaseToxSpec>();
}
