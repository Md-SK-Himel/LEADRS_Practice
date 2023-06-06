using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoObs
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasesAoObs DreCasesAoObs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesAoObs == null)
            {
                return NotFound();
            }

            var drecasesaoobs = await _context.DreCasesAoObs.FirstOrDefaultAsync(m => m.ObservationId == id);

            if (drecasesaoobs == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesAoObs = drecasesaoobs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesAoObs == null)
            {
                return NotFound();
            }
            var drecasesaoobs = await _context.DreCasesAoObs.FindAsync(id);

            if (drecasesaoobs != null)
            {
                DreCasesAoObs = drecasesaoobs;
                _context.DreCasesAoObs.Remove(DreCasesAoObs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
