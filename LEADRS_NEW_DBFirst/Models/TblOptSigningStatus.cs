using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_SigningStatus", Schema = "Form")]
public partial class TblOptSigningStatus
{
    [Key]
    public int SigningStatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<SigningRequestReportAction> SigningRequestReportActions { get; set; } = new List<SigningRequestReportAction>();

    [InverseProperty("Status")]
    public virtual ICollection<SigningRequestReport> SigningRequestReports { get; set; } = new List<SigningRequestReport>();

    [InverseProperty("Status")]
    public virtual ICollection<SigningRequest> SigningRequests { get; set; } = new List<SigningRequest>();
}
