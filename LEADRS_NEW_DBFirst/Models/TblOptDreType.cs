using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_TYPES", Schema = "DRE")]
public partial class TblOptDreType
{
    [Key]
    [Column("DRETypeId")]
    public int DretypeId { get; set; }

    [StringLength(50)]
    public string? TypeName { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public bool Active { get; set; }

    [InverseProperty("DreType")]
    public virtual ICollection<DreCase> DreCases { get; set; } = new List<DreCase>();
}
