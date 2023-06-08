using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class PriorDepartment
{
    [Key]
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int OrganizationId { get; set; }
}
