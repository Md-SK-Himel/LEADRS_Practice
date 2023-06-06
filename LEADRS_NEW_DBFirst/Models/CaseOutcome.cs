using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Index("OrganizationId", Name = "IX_CaseOutcomes_OrganizationId")]
public partial class CaseOutcome
{
    [Key]
    public int CaseOutcomeId { get; set; }

    [StringLength(50)]
    public string? CaseNumber { get; set; }

    public int CaseId { get; set; }

    public int? OrganizationId { get; set; }

    [Required]
    public bool? Submitted { get; set; }

    [StringLength(225)]
    public string? ReferenceNumber { get; set; }

    public bool? ChargeAccepted { get; set; }

    public bool? CaseDismissed { get; set; }

    public bool? CasePlea { get; set; }

    public bool? CaseTrial { get; set; }

    public int? AcceptedOffenseId { get; set; }

    public int? CaseOutcomeDismissalId { get; set; }

    public int? CaseOutcomePleaId { get; set; }

    public int? CaseOutcomeTrialId { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? OutcomeNarrative { get; set; }

    public bool? Active { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    [ForeignKey("OrganizationId")]
    [InverseProperty("CaseOutcomes")]
    public virtual Organization? Organization { get; set; }
}
