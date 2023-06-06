using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

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
      public DreCaseRb DreCaseRb { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseRbs == null)
            {
                return NotFound();
            }

            var drecaserb = await _context.DreCaseRbs.FirstOrDefaultAsync(m => m.DreCaseRbid == id);

            if (drecaserb == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseRb = drecaserb;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseRbs == null)
            {
                return NotFound();
            }
            var drecaserb = await _context.DreCaseRbs.FindAsync(id);

            if (drecaserb != null)
            {
                DreCaseRb = drecaserb;
                _context.DreCaseRbs.Remove(DreCaseRb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
