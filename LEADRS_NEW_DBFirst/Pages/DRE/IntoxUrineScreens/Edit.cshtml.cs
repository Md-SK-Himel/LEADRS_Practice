using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxUrineScreens
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseIntoxUrineScreen DreCaseIntoxUrineScreen { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxUrineScreens == null)
            {
                return NotFound();
            }

            var drecaseintoxurinescreen =  await _context.DreCaseIntoxUrineScreens.FirstOrDefaultAsync(m => m.DreUrineToxResultId == id);
            if (drecaseintoxurinescreen == null)
            {
                return NotFound();
            }
            DreCaseIntoxUrineScreen = drecaseintoxurinescreen;
           ViewData["DreCaseIntoxilyzerReportId"] = new SelectList(_context.DreCaseIntoxilyzerReports, "DreCaseIntoxilyzerReportId", "DreCaseIntoxilyzerReportId");
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

            _context.Attach(DreCaseIntoxUrineScreen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseIntoxUrineScreenExists(DreCaseIntoxUrineScreen.DreUrineToxResultId))
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

        private bool DreCaseIntoxUrineScreenExists(int id)
        {
          return (_context.DreCaseIntoxUrineScreens?.Any(e => e.DreUrineToxResultId == id)).GetValueOrDefault();
        }
    }
}
