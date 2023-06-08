using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("AdditionalOffenses", Schema = "DUI")]
[Index("CaseOffenseId", Name = "IX_AdditionalOffenses_CaseOffenseId")]
public partial class AdditionalOffense
{
    [Key]
    public int AdditionalOffenseId { get; set; }

    public int CaseOffenseId { get; set; }

    public string? AdditionalOffeseDesc { get; set; }

    [ForeignKey("CaseOffenseId")]
    [InverseProperty("AdditionalOffenses")]
    public virtual CaseOffense CaseOffense { get; set; } = null!;
}
