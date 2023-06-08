using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_InterviewQuestions")]
public partial class LuInterviewQuestion
{
    [Key]
    public int QuestionId { get; set; }

    public int QuestionOrder { get; set; }

    [StringLength(250)]
    public string Question { get; set; } = null!;

    public bool Active { get; set; }
}
