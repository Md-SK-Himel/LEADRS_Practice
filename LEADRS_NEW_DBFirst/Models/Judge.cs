using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class Judge
{
    [Key]
    public int JudgeId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    public string? CourtNumber { get; set; }

    public string? UserId { get; set; }

    [InverseProperty("Judge")]
    public virtual ICollection<JudgeCourtType> JudgeCourtTypes { get; set; } = new List<JudgeCourtType>();
}
