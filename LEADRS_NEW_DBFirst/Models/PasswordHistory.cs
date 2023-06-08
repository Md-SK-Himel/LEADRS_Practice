using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("PasswordHistory")]
public partial class PasswordHistory
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? UserId { get; set; }

    [Unicode(false)]
    public string? PasswordHash { get; set; }

    public DateTime CreateDate { get; set; }
}
