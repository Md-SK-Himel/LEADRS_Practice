using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class JudgeCounty
{
    [Key]
    public int JudgeCountyId { get; set; }

    public int OrganizationId { get; set; }

    public int CountyId { get; set; }

    public bool Active { get; set; }
}
