using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoInterviews
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
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

            var drecasearrestingofficerinterview =  await _context.DreCaseAoInterviews.FirstOrDefaultAsync(m => m.InterviewId == id);
            if (drecasearrestingofficerinterview == null)
            {
                return NotFound();
            }
            DreCaseArrestingOfficerInterview = drecasearrestingofficerinterview;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DreCaseArrestingOfficerInterview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseArrestingOfficerInterviewExists(DreCaseArrestingOfficerInterview.InterviewId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DreCaseArrestingOfficerInterviewExists(int id)
        {
          return (_context.DreCaseAoInterviews?.Any(e => e.InterviewId == id)).GetValueOrDefault();
        }
    }
}
