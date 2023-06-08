using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Offenses
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseOffense DreCaseOffense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOffenses == null)
            {
                return NotFound();
            }

            var drecaseoffense = await _context.DreCasesOffenses.FirstOrDefaultAsync(m => m.DreCaseOffenseId == id);

            if (drecaseoffense == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseOffense = drecaseoffense;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesOffenses == null)
            {
                return NotFound();
            }
            var drecaseoffense = await _context.DreCasesOffenses.FindAsync(id);

            if (drecaseoffense != null)
            {
                DreCaseOffense = drecaseoffense;
                _context.DreCasesOffenses.Remove(DreCaseOffense);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
