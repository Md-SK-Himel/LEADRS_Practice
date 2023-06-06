using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_ROLES", Schema = "DRE")]
public partial class TblOptDreRole
{
    [Key]
    [Column("DRERoleId")]
    public int DreroleId { get; set; }

    [StringLength(50)]
    public string? Role { get; set; }

    public bool Active { get; set; }

    [Required]
    public bool? IsOfficerRole { get; set; }

    [InverseProperty("DreRole")]
    public virtual ICollection<DreCase> DreCases { get; set; } = new List<DreCase>();

    [InverseProperty("DreRole")]
    public virtual ICollection<DreCasesOtherOfficer> DreCasesOtherOfficers { get; set; } = new List<DreCasesOtherOfficer>();
}
