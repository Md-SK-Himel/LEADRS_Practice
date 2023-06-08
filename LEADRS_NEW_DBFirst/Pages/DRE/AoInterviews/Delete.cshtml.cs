using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoInterviews
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseArrestingOfficerInterview DreCaseArrestingOfficerInterview { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoInterviews == null)
            {
                return NotFound();
            }

            var drecasearrestingofficerinterview = await _context.DreCaseAoInterviews.FirstOrDefaultAsync(m => m.InterviewId == id);

            if (drecasearrestingofficerinterview == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseArrestingOfficerInterview = drecasearrestingofficerinterview;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseAoInterviews == null)
            {
                return NotFound();
            }
            var drecasearrestingofficerinterview = await _context.DreCaseAoInterviews.FindAsync(id);

            if (drecasearrestingofficerinterview != null)
            {
                DreCaseArrestingOfficerInterview = drecasearrestingofficerinterview;
                _context.DreCaseAoInterviews.Remove(DreCaseArrestingOfficerInterview);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
