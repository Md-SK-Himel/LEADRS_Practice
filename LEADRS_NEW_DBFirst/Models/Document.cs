using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Documents", Schema = "DUI")]
[Index("DocumentTypeId", Name = "IX_Documents_DocumentTypeId")]
[Index("FileTypeId", Name = "IX_Documents_FileTypeId")]
public partial class Document
{
    [Key]
    public int DocumentId { get; set; }

    public int? DocumentTypeId { get; set; }

    public int? FileTypeId { get; set; }

    public string? DocumentName { get; set; }

    public string? OriginalFileName { get; set; }

    public string? PhysicalFileName { get; set; }

    public DateTime DocumentDate { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    [StringLength(100)]
    public string? CreatedBy { get; set; }

    public int? ObjectId { get; set; }

    public int? ObjectTypeId { get; set; }

    [StringLength(100)]
    public string? UpdatedBy { get; set; }

    [ForeignKey("DocumentTypeId")]
    [InverseProperty("Documents")]
    public virtual TblOptDocumentType? DocumentType { get; set; }

    [InverseProperty("Document")]
    public virtual ICollection<EvidenceDocument> EvidenceDocuments { get; set; } = new List<EvidenceDocument>();

    [ForeignKey("FileTypeId")]
    [InverseProperty("Documents")]
    public virtual TblOptDocumentFileType? FileType { get; set; }
}
