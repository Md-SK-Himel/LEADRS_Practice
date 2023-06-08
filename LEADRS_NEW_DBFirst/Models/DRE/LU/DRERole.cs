using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DRE_ROLES", Schema = "DRE")]
public class DRERole
{
    [Key]
    public int DRERoleId { get; set; }

    [StringLength(50)]
    public string Role { get; set; }

    public bool Active { get; set; }

    [Required]
    public bool? IsOfficerRole { get; set; }

    public virtual ICollection<DRECase> DreCases { get; set; } = new List<DRECase>();

    public virtual ICollection<DreCaseOtherOfficer> DreCasesOtherOfficers { get; set; } = new List<DreCaseOtherOfficer>();
}
