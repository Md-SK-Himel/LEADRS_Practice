using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DREMajorIndicators
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreMajorIndicator DreMajorIndicator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreMajorIndicators == null)
            {
                return NotFound();
            }

            var dremajorindicator = await _context.TblOptDreMajorIndicators.FirstOrDefaultAsync(m => m.DreMajorIndicatorId == id);

            if (dremajorindicator == null)
            {
                return NotFound();
            }
            else 
            {
                DreMajorIndicator = dremajorindicator;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreMajorIndicators == null)
            {
                return NotFound();
            }
            var dremajorindicator = await _context.TblOptDreMajorIndicators.FindAsync(id);

            if (dremajorindicator != null)
            {
                DreMajorIndicator = dremajorindicator;
                _context.TblOptDreMajorIndicators.Remove(DreMajorIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
