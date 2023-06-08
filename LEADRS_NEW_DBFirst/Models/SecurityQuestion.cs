using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SecurityQuestion")]
public partial class SecurityQuestion
{
    [Key]
    public int QuestionId { get; set; }

    public string? Question { get; set; }

    public bool IsActive { get; set; }
}
