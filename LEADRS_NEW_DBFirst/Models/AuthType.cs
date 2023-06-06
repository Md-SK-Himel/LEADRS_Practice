using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("AuthType")]
public partial class AuthType
{
    [Key]
    public int AuthTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AuthTypeName { get; set; }

    public bool Active { get; set; }
}
