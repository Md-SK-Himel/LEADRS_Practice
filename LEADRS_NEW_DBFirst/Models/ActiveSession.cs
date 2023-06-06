using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class ActiveSession
{
    [Key]
    public int ActiveSessionsId { get; set; }

    public string? SessionId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? CreatedDate { get; set; }

    public string? BrowserName { get; set; }

    public string? Device { get; set; }
}
