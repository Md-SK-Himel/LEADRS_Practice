using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Keyless]
[Table("Counter", Schema = "HangFire")]
public partial class Counter
{
    [StringLength(100)]
    public string Key { get; set; } = null!;

    public int Value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireAt { get; set; }
}
