using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningRequests", Schema = "Form")]
[Index("SigningTemplateId", Name = "IX_SigningRequests_SigningTemplateId")]
[Index("StatusId", Name = "IX_SigningRequests_StatusId")]
public partial class SigningRequest
{
    [Key]
    public int SigningRequestId { get; set; }

    public int SigningTemplateId { get; set; }

    public string? OwnerId { get; set; }

    public string? ExternalRequestId { get; set; }

    public int StatusId { get; set; }

    public int EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? OtherIdentifier { get; set; }

    public DateTime RequestedDate { get; set; }

    [InverseProperty("SigningRequest")]
    public virtual ICollection<SigningRequestReport> SigningRequestReports { get; set; } = new List<SigningRequestReport>();

    [InverseProperty("SigningRequest")]
    public virtual ICollection<SigningRequestSigner> SigningRequestSigners { get; set; } = new List<SigningRequestSigner>();

    [ForeignKey("SigningTemplateId")]
    [InverseProperty("SigningRequests")]
    public virtual SigningTemplate SigningTemplate { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("SigningRequests")]
    public virtual TblOptSigningStatus Status { get; set; } = null!;
}
