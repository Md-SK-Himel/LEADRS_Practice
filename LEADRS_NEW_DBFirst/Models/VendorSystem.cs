using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("VendorSystem")]
public partial class VendorSystem
{
    [Key]
    public int VendorId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VendorSystemName { get; set; }

    public bool Active { get; set; }
}
