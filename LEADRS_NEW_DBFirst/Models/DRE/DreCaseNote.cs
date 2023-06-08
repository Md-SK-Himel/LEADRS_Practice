using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_NOTES", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_NOTES_DreCaseId")]
[Index("DreCaseNoteTypeId", Name = "IX_DRE_CASE_NOTES_DreCaseNoteTypeId")]
public class DreCaseNote : VmAudit
    {
        [Key]
        public int DreCaseNoteId { get; set; }

        public int DreCaseId { get; set; }

        [ForeignKey("DreCaseId")]
        public DRECase DreCase { get; set; }

        public int DreCaseNoteTypeId { get; set; }

        [ForeignKey("DreCaseNoteTypeId")]
        public DreCaseNoteType DreCaseNoteType { get; set; }

        public string Notes { get; set; }

        public int? ParentId { get; set; }
    }
