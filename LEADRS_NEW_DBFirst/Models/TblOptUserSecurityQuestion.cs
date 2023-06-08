using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_User_Security_Questions", Schema = "DUI")]
public partial class TblOptUserSecurityQuestion
{
    [Key]
    public int QuestionId { get; set; }

    [StringLength(2000)]
    public string? Question { get; set; }

    public bool Active { get; set; }
}
