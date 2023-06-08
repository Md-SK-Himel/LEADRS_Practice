using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DREFirstIndicators
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseFirstIndicator DreCaseFirstIndicator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreFirstIndicators == null)
            {
                return NotFound();
            }

            var drecasefirstindicator = await _context.TblOptDreFirstIndicators.FirstOrDefaultAsync(m => m.DreCaseFirstIndicatorId == id);

            if (drecasefirstindicator == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseFirstIndicator = drecasefirstindicator;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreFirstIndicators == null)
            {
                return NotFound();
            }
            var drecasefirstindicator = await _context.TblOptDreFirstIndicators.FindAsync(id);

            if (drecasefirstindicator != null)
            {
                DreCaseFirstIndicator = drecasefirstindicator;
                _context.TblOptDreFirstIndicators.Remove(DreCaseFirstIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
