using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("PhysicalEvidences", Schema = "DUI")]
[Index("CaseId", Name = "IX_PhysicalEvidences_CaseId")]
public partial class PhysicalEvidence
{
    [Key]
    public int PhysicalEvidenceId { get; set; }

    public int CaseId { get; set; }

    public bool DispatchRecordingInclude { get; set; }

    [StringLength(2000)]
    public string? ExplainDispacthRecording { get; set; }

    [StringLength(2000)]
    public string? OtherPhysicalEvidence { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("PhysicalEvidences")]
    public virtual CaseHeader Case { get; set; } = null!;

    [InverseProperty("PhysicalEvidence")]
    public virtual ICollection<EvidenceRecording> EvidenceRecordings { get; set; } = new List<EvidenceRecording>();
}
