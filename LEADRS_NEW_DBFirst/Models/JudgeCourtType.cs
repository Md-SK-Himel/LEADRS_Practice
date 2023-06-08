using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[PrimaryKey("JudgeId", "CourtTypeId")]
[Table("JudgeCourtType")]
[Index("CourtTypeId", Name = "IX_JudgeCourtType_CourtTypeId")]
public partial class JudgeCourtType
{
    [Key]
    public int JudgeId { get; set; }

    [Key]
    public int CourtTypeId { get; set; }

    public bool IsPrimary { get; set; }

    [ForeignKey("CourtTypeId")]
    [InverseProperty("JudgeCourtTypes")]
    public virtual LuCourtType CourtType { get; set; } = null!;

    [ForeignKey("JudgeId")]
    [InverseProperty("JudgeCourtTypes")]
    public virtual Judge Judge { get; set; } = null!;
}
