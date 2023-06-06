using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_AO_TYPES", Schema = "DRE")]
public partial class TblOptAoType
{
    [Key]
    public int ArrestingOfficerTypeId { get; set; }

    public string? OfficerType { get; set; }

    public bool Active { get; set; }

    [InverseProperty("ArrestingOfficerType")]
    public virtual ICollection<DreDefendant> DreDefendants { get; set; } = new List<DreDefendant>();
}
