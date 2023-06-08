using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("EvidenceRecordings", Schema = "DUI")]
[Index("PhysicalEvidenceId", Name = "IX_EvidenceRecordings_PhysicalEvidenceId")]
public partial class EvidenceRecording
{
    [Key]
    public int EvidenceRecordingId { get; set; }

    public int PhysicalEvidenceId { get; set; }

    public DateTime? TimeBegan { get; set; }

    public DateTime? TimeStop { get; set; }

    public bool OnBoatRecording { get; set; }

    public bool OnShoreRecording { get; set; }

    public bool OnBodyCameraRecording { get; set; }

    public bool IntoxicationInvestigation { get; set; }

    [Column("FST")]
    public bool Fst { get; set; }

    public bool TransportToJail { get; set; }

    [StringLength(250)]
    public string? OtherActions { get; set; }

    [StringLength(100)]
    public string? NameOfOfficer { get; set; }

    [StringLength(500)]
    public string? EvidenceNumber { get; set; }

    [Required]
    public bool? HasVideoTape { get; set; }

    [StringLength(500)]
    public string? NoTapeExplain { get; set; }

    [ForeignKey("PhysicalEvidenceId")]
    [InverseProperty("EvidenceRecordings")]
    public virtual PhysicalEvidence PhysicalEvidence { get; set; } = null!;
}
