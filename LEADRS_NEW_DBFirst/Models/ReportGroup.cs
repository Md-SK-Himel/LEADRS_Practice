using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("ReportGroups", Schema = "Form")]
public partial class ReportGroup
{
    [Key]
    public int ReportGroupId { get; set; }

    public string? GroupName { get; set; }

    public bool Active { get; set; }

    public int Order { get; set; }

    public int ReportGroupType { get; set; }

    [InverseProperty("ReportGroup")]
    public virtual ICollection<ReportForm> ReportForms { get; set; } = new List<ReportForm>();
}
