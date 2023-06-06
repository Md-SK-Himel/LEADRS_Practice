using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("CaseHeaders", Schema = "DUI")]
[Index("ModeId", Name = "IX_CaseHeaders_ModeId")]
[Index("StatusId", Name = "IX_CaseHeaders_StatusId")]
public partial class CaseHeader
{
    [Key]
    public int CaseId { get; set; }

    public string UniqueId { get; set; } = null!;

    public int StatusId { get; set; }

    public int ModelId { get; set; }

    public int? LockedByOfficerId { get; set; }

    public DateTime? LockedDate { get; set; }

    public int? ApprovedByOfficerId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int OrganizationId { get; set; }

    public int LocationId { get; set; }

    public DateTime DateEntered { get; set; }

    public string AgencyCaseNumber { get; set; } = null!;

    public string? ServiceNumber { get; set; }

    public string? District { get; set; }

    public string? Grid { get; set; }

    public int? Version { get; set; }

    public string? ArrestNumber { get; set; }

    public int OfficerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool Active { get; set; }

    public int ModeId { get; set; }

    [Unicode(false)]
    public string? ProbableCause { get; set; }

    [Required]
    public bool? IsTrainingPurpose { get; set; }

    [Required]
    [Column("PaidTxDOT")]
    public bool? PaidTxDot { get; set; }

    public int? StepGrantTypeId { get; set; }

    public string? CaseOwnerAgency { get; set; }

    public string? CaseOwnerBadge { get; set; }

    public int CaseOwnerDepartmentId { get; set; }

    public string? CaseOwnerId { get; set; }

    public string? CaseOwnerName { get; set; }

    public string? CaseOwnerRank { get; set; }

    [InverseProperty("Case")]
    public virtual ICollection<CaseOffense> CaseOffenses { get; set; } = new List<CaseOffense>();

    [InverseProperty("Case")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();

    [InverseProperty("Case")]
    public virtual ICollection<CaseViolation> CaseViolations { get; set; } = new List<CaseViolation>();

    [InverseProperty("Case")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();

    [InverseProperty("Case")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();

    [InverseProperty("DuiCase")]
    public virtual ICollection<DuiCaseNote> DuiCaseNotes { get; set; } = new List<DuiCaseNote>();

    [InverseProperty("Case")]
    public virtual ICollection<EvidenceDocument> EvidenceDocuments { get; set; } = new List<EvidenceDocument>();

    [InverseProperty("Case")]
    public virtual ICollection<FieldSobrietyTest> FieldSobrietyTests { get; set; } = new List<FieldSobrietyTest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstFingerToNoseTest> FstFingerToNoseTests { get; set; } = new List<FstFingerToNoseTest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstHandCoordination> FstHandCoordinations { get; set; } = new List<FstHandCoordination>();

    [InverseProperty("Case")]
    public virtual ICollection<FstHgntest> FstHgntests { get; set; } = new List<FstHgntest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstOneLegStandTest> FstOneLegStandTests { get; set; } = new List<FstOneLegStandTest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstOtherTest> FstOtherTests { get; set; } = new List<FstOtherTest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstPalmPatTest> FstPalmPatTests { get; set; } = new List<FstPalmPatTest>();

    [InverseProperty("Case")]
    public virtual ICollection<FstWalkAndTurnTest> FstWalkAndTurnTests { get; set; } = new List<FstWalkAndTurnTest>();

    [ForeignKey("ModeId")]
    [InverseProperty("CaseHeaders")]
    public virtual TblOptSystemMode Mode { get; set; } = null!;

    [InverseProperty("Case")]
    public virtual ICollection<OtherOfficer> OtherOfficers { get; set; } = new List<OtherOfficer>();

    [InverseProperty("Case")]
    public virtual ICollection<PhysicalEvidence> PhysicalEvidences { get; set; } = new List<PhysicalEvidence>();

    [InverseProperty("Case")]
    public virtual ICollection<SpecimenReport> SpecimenReports { get; set; } = new List<SpecimenReport>();

    [ForeignKey("StatusId")]
    [InverseProperty("CaseHeaders")]
    public virtual TblOptStatus Status { get; set; } = null!;

    [InverseProperty("Case")]
    public virtual ICollection<StepOfficerShiftCase> StepOfficerShiftCases { get; set; } = new List<StepOfficerShiftCase>();

    [InverseProperty("Case")]
    public virtual ICollection<Witness> Witnesses { get; set; } = new List<Witness>();
}
