using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("ReportForms", Schema = "Form")]
[Index("ReportGroupId", Name = "IX_ReportForms_ReportGroupId")]
public partial class ReportForm
{
    [Key]
    public int ReportFormId { get; set; }

    public string? ReportName { get; set; }

    public string? FileName { get; set; }

    public string? FileExtension { get; set; }

    public string? RevVersion { get; set; }

    public bool Active { get; set; }

    public bool SubReport { get; set; }

    public int? ReportGroupId { get; set; }

    [ForeignKey("ReportGroupId")]
    [InverseProperty("ReportForms")]
    public virtual ReportGroup? ReportGroup { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<SigningRequestReport> SigningRequestReports { get; set; } = new List<SigningRequestReport>();

    [InverseProperty("ReportForm")]
    public virtual ICollection<SigningTemplateReport> SigningTemplateReports { get; set; } = new List<SigningTemplateReport>();
}
