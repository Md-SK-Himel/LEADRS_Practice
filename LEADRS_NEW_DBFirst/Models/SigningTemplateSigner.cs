using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SigningTemplateSigners", Schema = "Form")]
[Index("SignerTypeId", Name = "IX_SigningTemplateSigners_SignerTypeId")]
[Index("SigningTemplateId", Name = "IX_SigningTemplateSigners_SigningTemplateId")]
public partial class SigningTemplateSigner
{
    [Key]
    public int SigningTemplateSignerId { get; set; }

    public int SigningTemplateId { get; set; }

    public int SigningOrder { get; set; }

    public int SignerTypeId { get; set; }

    [ForeignKey("SignerTypeId")]
    [InverseProperty("SigningTemplateSigners")]
    public virtual TblOptSignerType SignerType { get; set; } = null!;

    [ForeignKey("SigningTemplateId")]
    [InverseProperty("SigningTemplateSigners")]
    public virtual SigningTemplate SigningTemplate { get; set; } = null!;
}
