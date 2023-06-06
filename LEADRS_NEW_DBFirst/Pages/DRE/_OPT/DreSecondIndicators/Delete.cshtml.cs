using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreSecondIndicators
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreSecondIndicator TblOptDreSecondIndicator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreSecondIndicators == null)
            {
                return NotFound();
            }

            var tbloptdresecondindicator = await _context.TblOptDreSecondIndicators.FirstOrDefaultAsync(m => m.DreCaseSecondIndicatorId == id);

            if (tbloptdresecondindicator == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreSecondIndicator = tbloptdresecondindicator;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreSecondIndicators == null)
            {
                return NotFound();
            }
            var tbloptdresecondindicator = await _context.TblOptDreSecondIndicators.FindAsync(id);

            if (tbloptdresecondindicator != null)
            {
                TblOptDreSecondIndicator = tbloptdresecondindicator;
                _context.TblOptDreSecondIndicators.Remove(TblOptDreSecondIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
