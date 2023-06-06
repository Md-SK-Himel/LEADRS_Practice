using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class AuditChange
{
    [Key]
    [Column("Audit_Id")]
    public int AuditId { get; set; }

    [Column("Audit_Action")]
    [StringLength(30)]
    [Unicode(false)]
    public string? AuditAction { get; set; }

    [Column("Audit_Object")]
    [StringLength(30)]
    [Unicode(false)]
    public string? AuditObject { get; set; }

    [Column("Key_Id")]
    [StringLength(450)]
    [Unicode(false)]
    public string? KeyId { get; set; }

    [Column("Updated_By_User")]
    [StringLength(450)]
    [Unicode(false)]
    public string? UpdatedByUser { get; set; }

    [Column("User_Name")]
    [StringLength(256)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Unicode(false)]
    public string? Changes { get; set; }

    [Column("Updated_On", TypeName = "datetime")]
    public DateTime UpdatedOn { get; set; }

    [Column("Session_Id")]
    [Unicode(false)]
    public string? SessionId { get; set; }
}
