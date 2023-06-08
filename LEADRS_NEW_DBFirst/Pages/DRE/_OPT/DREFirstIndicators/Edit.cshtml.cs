using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DREFirstIndicators
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
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

            var drecasefirstindicator =  await _context.TblOptDreFirstIndicators.FirstOrDefaultAsync(m => m.DreCaseFirstIndicatorId == id);
            if (drecasefirstindicator == null)
            {
                return NotFound();
            }
            DreCaseFirstIndicator = drecasefirstindicator;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DreCaseFirstIndicator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseFirstIndicatorExists(DreCaseFirstIndicator.DreCaseFirstIndicatorId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DreCaseFirstIndicatorExists(int id)
        {
          return (_context.TblOptDreFirstIndicators?.Any(e => e.DreCaseFirstIndicatorId == id)).GetValueOrDefault();
        }
    }
}
