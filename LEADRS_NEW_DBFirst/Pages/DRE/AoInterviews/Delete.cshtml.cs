using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

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
      public DreCaseAoInterview DreCaseAoInterview { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoInterviews == null)
            {
                return NotFound();
            }

            var drecaseaointerview = await _context.DreCaseAoInterviews.FirstOrDefaultAsync(m => m.InterviewId == id);

            if (drecaseaointerview == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseAoInterview = drecaseaointerview;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseAoInterviews == null)
            {
                return NotFound();
            }
            var drecaseaointerview = await _context.DreCaseAoInterviews.FindAsync(id);

            if (drecaseaointerview != null)
            {
                DreCaseAoInterview = drecaseaointerview;
                _context.DreCaseAoInterviews.Remove(DreCaseAoInterview);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
