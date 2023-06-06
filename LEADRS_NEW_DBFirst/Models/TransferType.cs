using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TransferType")]
public partial class TransferType
{
    [Key]
    public int TransferTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransferTypeName { get; set; }

    public bool Active { get; set; }
}
