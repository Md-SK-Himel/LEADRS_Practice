using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_CourtType")]
public partial class LuCourtType
{
    [Key]
    public int CourtTypeId { get; set; }

    public string? CourtTypeName { get; set; }

    public bool Active { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }

    [InverseProperty("CourtType")]
    public virtual ICollection<JudgeCourtType> JudgeCourtTypes { get; set; } = new List<JudgeCourtType>();

    [ForeignKey("CourtTypeId")]
    [InverseProperty("CourtTypes")]
    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
