using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DocumentTypes", Schema = "DUI")]
public partial class TblOptDocumentType
{
    [Key]
    public int DocumentTypeId { get; set; }

    public string? DocumentTypeName { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    [InverseProperty("DocumentType")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
