using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_RelationshipType")]
public partial class LuRelationshipType
{
    [Key]
    public int RelationshipTypeId { get; set; }

    public string? RelationshipName { get; set; }

    public int CounterRelationshipTypeId { get; set; }

    public bool Dating { get; set; }
}
