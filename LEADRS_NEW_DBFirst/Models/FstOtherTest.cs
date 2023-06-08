using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_OtherTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_OtherTests_CaseId")]
public partial class FstOtherTest
{
    [Key]
    public int OtherTestId { get; set; }

    public int CaseId { get; set; }

    public bool FingerCountGiven { get; set; }

    public string? FingerCountDesc { get; set; }

    public bool AlphabetTestGiven { get; set; }

    public string? AlphabetTestDesc { get; set; }

    public string? OtherTestDesc { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstOtherTests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
