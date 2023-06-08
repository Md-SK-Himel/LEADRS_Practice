using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_AO_TYPES", Schema = "DRE")]
public class ArrestingOfficerType
{
    [Key]
    public int ArrestingOfficerTypeId { get; set; }

    public string OfficerType { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DreCaseDefendant> DreDefendants { get; set; } = new List<DreCaseDefendant>();
}
