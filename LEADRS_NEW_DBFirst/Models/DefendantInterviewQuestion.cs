using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantInterviewQuestions", Schema = "DUI")]
[Index("DefendantInterviewId", Name = "IX_DefendantInterviewQuestions_DefendantInterviewId")]
[Index("InterviewQuestionId", Name = "IX_DefendantInterviewQuestions_InterviewQuestionId")]
public partial class DefendantInterviewQuestion
{
    [Key]
    public int DefendantInterviewQuestionId { get; set; }

    public int DefendantInterviewId { get; set; }

    public int InterviewQuestionId { get; set; }

    public string? Answer { get; set; }

    [ForeignKey("DefendantInterviewId")]
    [InverseProperty("DefendantInterviewQuestions")]
    public virtual DefendantInterview DefendantInterview { get; set; } = null!;

    [ForeignKey("InterviewQuestionId")]
    [InverseProperty("DefendantInterviewQuestions")]
    public virtual TblOptInterviewQuestion InterviewQuestion { get; set; } = null!;
}
