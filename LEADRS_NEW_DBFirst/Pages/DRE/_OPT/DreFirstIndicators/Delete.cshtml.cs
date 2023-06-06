using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreFirstIndicators
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreFirstIndicator TblOptDreFirstIndicator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreFirstIndicators == null)
            {
                return NotFound();
            }

            var tbloptdrefirstindicator = await _context.TblOptDreFirstIndicators.FirstOrDefaultAsync(m => m.DreCaseFirstIndicatorId == id);

            if (tbloptdrefirstindicator == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreFirstIndicator = tbloptdrefirstindicator;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreFirstIndicators == null)
            {
                return NotFound();
            }
            var tbloptdrefirstindicator = await _context.TblOptDreFirstIndicators.FindAsync(id);

            if (tbloptdrefirstindicator != null)
            {
                TblOptDreFirstIndicator = tbloptdrefirstindicator;
                _context.TblOptDreFirstIndicators.Remove(TblOptDreFirstIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
