using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningTemplateReportActions", Schema = "Form")]
[Index("SignerActionId", Name = "IX_SigningTemplateReportActions_SignerActionId")]
[Index("SignerTypeId", Name = "IX_SigningTemplateReportActions_SignerTypeId")]
[Index("SigningTemplateReportId", Name = "IX_SigningTemplateReportActions_SigningTemplateReportId")]
public partial class SigningTemplateReportAction
{
    [Key]
    public int SigningTemplateReportActionId { get; set; }

    public int SigningTemplateReportId { get; set; }

    public int SignerTypeId { get; set; }

    public int SignerActionId { get; set; }

    [ForeignKey("SignerActionId")]
    [InverseProperty("SigningTemplateReportActions")]
    public virtual TblOptSigningAction SignerAction { get; set; } = null!;

    [ForeignKey("SignerTypeId")]
    [InverseProperty("SigningTemplateReportActions")]
    public virtual TblOptSignerType SignerType { get; set; } = null!;

    [ForeignKey("SigningTemplateReportId")]
    [InverseProperty("SigningTemplateReportActions")]
    public virtual SigningTemplateReport SigningTemplateReport { get; set; } = null!;
}
