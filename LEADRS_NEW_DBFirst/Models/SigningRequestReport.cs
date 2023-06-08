using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningRequestReport", Schema = "Form")]
[Index("ReportId", Name = "IX_SigningRequestReport_ReportId")]
[Index("SigningRequestId", Name = "IX_SigningRequestReport_SigningRequestId")]
[Index("StatusId", Name = "IX_SigningRequestReport_StatusId")]
public partial class SigningRequestReport
{
    [Key]
    public int SigningRequestReportId { get; set; }

    public int ReportId { get; set; }

    public int SigningRequestId { get; set; }

    public byte[]? GeneratedReport { get; set; }

    public int? StatusId { get; set; }

    public string? Notes { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("SigningRequestReports")]
    public virtual ReportForm Report { get; set; } = null!;

    [ForeignKey("SigningRequestId")]
    [InverseProperty("SigningRequestReports")]
    public virtual SigningRequest SigningRequest { get; set; } = null!;

    [InverseProperty("SigningRequestReport")]
    public virtual ICollection<SigningRequestReportAction> SigningRequestReportActions { get; set; } = new List<SigningRequestReportAction>();

    [ForeignKey("StatusId")]
    [InverseProperty("SigningRequestReports")]
    public virtual TblOptSigningStatus? Status { get; set; }
}
