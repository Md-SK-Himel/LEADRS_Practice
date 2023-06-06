using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Officer")]
public partial class Officer
{
    [Key]
    public int OfficerId { get; set; }

    [StringLength(450)]
    public string? UserId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Rank { get; set; }

    [Column("PID")]
    [StringLength(20)]
    public string? Pid { get; set; }

    [StringLength(20)]
    public string? BadgeNo { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    [Column("DRENo")]
    public string? Dreno { get; set; }
}
