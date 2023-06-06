using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OrganizationSearchWarrantGroup")]
public partial class OrganizationSearchWarrantGroup
{
    [Key]
    public int OrganizationSearchWarrantGroupId { get; set; }

    public int SearchWarrantGroupIdFk { get; set; }

    public int OrganizationId { get; set; }
}
