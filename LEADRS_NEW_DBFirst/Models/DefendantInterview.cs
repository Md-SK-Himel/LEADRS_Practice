using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantInterviews", Schema = "DUI")]
[Index("DefendantId", Name = "IX_DefendantInterviews_DefendantId", IsUnique = true)]
public partial class DefendantInterview
{
    [Key]
    public int DefendantInterviewId { get; set; }

    public int DefendantId { get; set; }

    public bool MirandaWarningRead { get; set; }

    public bool MirandaInEngilish { get; set; }

    public bool MirandaInSpanish { get; set; }

    public bool StatedUnderstood { get; set; }

    [StringLength(255)]
    public string? ReadBy { get; set; }

    public DateTime? DateRead { get; set; }

    public DateTime? TimeRead { get; set; }

    public string? Comments { get; set; }

    [Required]
    public bool? AskOnVideo { get; set; }

    public DateTime? DateOfInterview { get; set; }

    [StringLength(1000)]
    public string? DefendantSpeech { get; set; }

    [Required]
    public bool? DoNotAskQuestion { get; set; }

    [Required]
    public bool? DoNotAskQuestionForLanguage { get; set; }

    public string? Interviewer { get; set; }

    public string? InterviewerId { get; set; }

    [Required]
    public bool? RefuseToAnswer { get; set; }

    public DateTime? TimeOfInterview { get; set; }

    [StringLength(2000)]
    public string? UnusualActions { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantInterview")]
    public virtual Defendant Defendant { get; set; } = null!;

    [InverseProperty("DefendantInterview")]
    public virtual ICollection<DefendantInterviewQuestion> DefendantInterviewQuestions { get; set; } = new List<DefendantInterviewQuestion>();
}
