using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DocumentFileTypes", Schema = "DUI")]
public partial class TblOptDocumentFileType
{
    [Key]
    public int FileTypeId { get; set; }

    [StringLength(150)]
    public string? FileName { get; set; }

    [StringLength(50)]
    public string? Extension { get; set; }

    [StringLength(150)]
    public string? Icon { get; set; }

    public bool Image { get; set; }

    [StringLength(100)]
    public string? MimeType { get; set; }

    public bool Active { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    [InverseProperty("FileType")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
