using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("EvidenceDocuments", Schema = "DUI")]
[Index("CaseId", Name = "IX_EvidenceDocuments_CaseId")]
[Index("DocumentId", Name = "IX_EvidenceDocuments_DocumentId")]
public partial class EvidenceDocument
{
    [Key]
    public int EvidenceDocumentId { get; set; }

    public int CaseId { get; set; }

    public int DocumentId { get; set; }

    public string? UploadedBy { get; set; }

    public DateTime? Uploaded { get; set; }

    public int? DocumentTypeId { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("EvidenceDocuments")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("DocumentId")]
    [InverseProperty("EvidenceDocuments")]
    public virtual Document Document { get; set; } = null!;
}
