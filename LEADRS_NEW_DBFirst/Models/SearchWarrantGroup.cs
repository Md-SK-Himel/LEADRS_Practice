using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SearchWarrantGroup")]
public partial class SearchWarrantGroup
{
    [Key]
    [Column("SWGroupId")]
    public int SwgroupId { get; set; }

    [Column("SWGroupName")]
    public string? SwgroupName { get; set; }
}
