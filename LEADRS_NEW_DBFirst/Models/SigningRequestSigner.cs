using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningRequestSigners", Schema = "Form")]
[Index("SignerTypeId", Name = "IX_SigningRequestSigners_SignerTypeId")]
[Index("SigningRequestId", Name = "IX_SigningRequestSigners_SigningRequestId")]
public partial class SigningRequestSigner
{
    [Key]
    public int SigningRequestSignerId { get; set; }

    public int SignerTypeId { get; set; }

    public int SignOrder { get; set; }

    public string? UserId { get; set; }

    public string? SignerName { get; set; }

    public string? SignerInitial { get; set; }

    public int SigningRequestId { get; set; }

    public bool IsLocalSigner { get; set; }

    [ForeignKey("SignerTypeId")]
    [InverseProperty("SigningRequestSigners")]
    public virtual TblOptSignerType SignerType { get; set; } = null!;

    [ForeignKey("SigningRequestId")]
    [InverseProperty("SigningRequestSigners")]
    public virtual SigningRequest SigningRequest { get; set; } = null!;

    [InverseProperty("SigningRequestSigner")]
    public virtual ICollection<SigningRequestReportAction> SigningRequestReportActions { get; set; } = new List<SigningRequestReportAction>();
}
