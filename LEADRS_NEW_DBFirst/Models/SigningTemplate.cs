using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningTemplates", Schema = "Form")]
public partial class SigningTemplate
{
    [Key]
    public int SigningTemplateId { get; set; }

    public string? TemplateName { get; set; }

    public int SearchWarrantGroupId { get; set; }

    [InverseProperty("SigningTemplate")]
    public virtual ICollection<SigningRequest> SigningRequests { get; set; } = new List<SigningRequest>();

    [InverseProperty("SigningTemplate")]
    public virtual ICollection<SigningTemplateReport> SigningTemplateReports { get; set; } = new List<SigningTemplateReport>();

    [InverseProperty("SigningTemplate")]
    public virtual ICollection<SigningTemplateSigner> SigningTemplateSigners { get; set; } = new List<SigningTemplateSigner>();
}
