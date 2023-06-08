using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Rbs
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseRombergBalance DreCaseRombergBalance { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseRbs == null)
            {
                return NotFound();
            }

            var drecaserombergbalance = await _context.DreCaseRbs.FirstOrDefaultAsync(m => m.DreCaseRBId == id);

            if (drecaserombergbalance == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseRombergBalance = drecaserombergbalance;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseRbs == null)
            {
                return NotFound();
            }
            var drecaserombergbalance = await _context.DreCaseRbs.FindAsync(id);

            if (drecaserombergbalance != null)
            {
                DreCaseRombergBalance = drecaserombergbalance;
                _context.DreCaseRbs.Remove(DreCaseRombergBalance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
