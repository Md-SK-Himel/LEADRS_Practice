using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningRequestReportActions", Schema = "Form")]
[Index("SigningActionId", Name = "IX_SigningRequestReportActions_SigningActionId")]
[Index("SigningRequestReportId", Name = "IX_SigningRequestReportActions_SigningRequestReportId")]
[Index("SigningRequestSignerId", Name = "IX_SigningRequestReportActions_SigningRequestSignerId")]
[Index("StatusId", Name = "IX_SigningRequestReportActions_StatusId")]
public partial class SigningRequestReportAction
{
    [Key]
    public int SigningRequestReportActionId { get; set; }

    public int SigningRequestReportId { get; set; }

    public int? SigningRequestSignerId { get; set; }

    public int SigningActionId { get; set; }

    public int? StatusId { get; set; }

    [ForeignKey("SigningActionId")]
    [InverseProperty("SigningRequestReportActions")]
    public virtual TblOptSigningAction SigningAction { get; set; } = null!;

    [ForeignKey("SigningRequestReportId")]
    [InverseProperty("SigningRequestReportActions")]
    public virtual SigningRequestReport SigningRequestReport { get; set; } = null!;

    [ForeignKey("SigningRequestSignerId")]
    [InverseProperty("SigningRequestReportActions")]
    public virtual SigningRequestSigner? SigningRequestSigner { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("SigningRequestReportActions")]
    public virtual TblOptSigningStatus? Status { get; set; }
}
