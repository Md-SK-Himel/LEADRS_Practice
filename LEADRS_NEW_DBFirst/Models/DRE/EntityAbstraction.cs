using LEADRS_NEW_DBFirst.Models.DRE;
using System.ComponentModel.DataAnnotations.Schema;

namespace LEADRS_NEW_DBFirst.Models.DRE;

public class EntityAbstraction
{
    public int DreCaseId { get; set; }

    [ForeignKey("DRECaseId")]
    public DRECase? DreCase { get; set; }
}
