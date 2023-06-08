using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Indicators
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseIndicator DreCaseIndicator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIndicators == null)
            {
                return NotFound();
            }

            var drecaseindicator = await _context.DreCaseIndicators.FirstOrDefaultAsync(m => m.DreCaseIndicatorId == id);

            if (drecaseindicator == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseIndicator = drecaseindicator;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseIndicators == null)
            {
                return NotFound();
            }
            var drecaseindicator = await _context.DreCaseIndicators.FindAsync(id);

            if (drecaseindicator != null)
            {
                DreCaseIndicator = drecaseindicator;
                _context.DreCaseIndicators.Remove(DreCaseIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
