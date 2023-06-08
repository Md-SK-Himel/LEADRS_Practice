using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_PhoneType")]
public partial class LuPhoneType
{
    [Key]
    public int PhoneTypeId { get; set; }

    [StringLength(50)]
    public string? PhoneTypeName { get; set; }

    [StringLength(50)]
    public string? PhoneIcon { get; set; }

    public bool Active { get; set; }
}
