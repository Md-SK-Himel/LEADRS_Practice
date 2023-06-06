using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_SignerTypes", Schema = "Form")]
public partial class TblOptSignerType
{
    [Key]
    public int SignerTypeId { get; set; }

    public string? SignerTypeName { get; set; }

    public bool CanRemote { get; set; }

    public bool CanCancelProcess { get; set; }

    public string? SignerSymbolStart { get; set; }

    public string? SignerSymbolEnd { get; set; }

    [InverseProperty("SignerType")]
    public virtual ICollection<SigningRequestSigner> SigningRequestSigners { get; set; } = new List<SigningRequestSigner>();

    [InverseProperty("SignerType")]
    public virtual ICollection<SigningTemplateReportAction> SigningTemplateReportActions { get; set; } = new List<SigningTemplateReportAction>();

    [InverseProperty("SignerType")]
    public virtual ICollection<SigningTemplateSigner> SigningTemplateSigners { get; set; } = new List<SigningTemplateSigner>();
}
