using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningTemplateReports", Schema = "Form")]
[Index("ReportFormId", Name = "IX_SigningTemplateReports_ReportFormId")]
[Index("SigningTemplateId", Name = "IX_SigningTemplateReports_SigningTemplateId")]
public partial class SigningTemplateReport
{
    [Key]
    public int SigningTemplateReportId { get; set; }

    public int SigningTemplateId { get; set; }

    public int ReportFormId { get; set; }

    public bool FormIsRequired { get; set; }

    [ForeignKey("ReportFormId")]
    [InverseProperty("SigningTemplateReports")]
    public virtual ReportForm ReportForm { get; set; } = null!;

    [ForeignKey("SigningTemplateId")]
    [InverseProperty("SigningTemplateReports")]
    public virtual SigningTemplate SigningTemplate { get; set; } = null!;

    [InverseProperty("SigningTemplateReport")]
    public virtual ICollection<SigningTemplateReportAction> SigningTemplateReportActions { get; set; } = new List<SigningTemplateReportAction>();
}
