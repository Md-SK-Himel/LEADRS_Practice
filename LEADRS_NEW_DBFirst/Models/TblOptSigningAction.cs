using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_SigningActions", Schema = "Form")]
public partial class TblOptSigningAction
{
    [Key]
    public int SigningActionId { get; set; }

    public string? ActionDesc { get; set; }

    public bool RequiredSigning { get; set; }

    public bool RequiredReview { get; set; }

    [InverseProperty("SigningAction")]
    public virtual ICollection<SigningRequestReportAction> SigningRequestReportActions { get; set; } = new List<SigningRequestReportAction>();

    [InverseProperty("SignerAction")]
    public virtual ICollection<SigningTemplateReportAction> SigningTemplateReportActions { get; set; } = new List<SigningTemplateReportAction>();
}
