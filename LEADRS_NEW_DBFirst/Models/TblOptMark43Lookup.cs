using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Mark43_Lookup", Schema = "DUI")]
public partial class TblOptMark43Lookup
{
    [Key]
    public int Mark43LookupId { get; set; }

    [StringLength(50)]
    public string? Mark43AttributeType { get; set; }

    [StringLength(50)]
    public string? Mark43Code { get; set; }

    [StringLength(50)]
    public string? Mark43Desc { get; set; }

    public int? LeadrsId { get; set; }

    public bool In { get; set; }

    public bool Out { get; set; }

    public int OrganizationId { get; set; }
}
