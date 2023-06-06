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

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxSalivaScreens
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseIntoxSalivaScreen DreCaseIntoxSalivaScreen { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxSalivaScreens == null)
            {
                return NotFound();
            }

            var drecaseintoxsalivascreen =  await _context.DreCaseIntoxSalivaScreens.FirstOrDefaultAsync(m => m.DreSalivaToxResultId == id);
            if (drecaseintoxsalivascreen == null)
            {
                return NotFound();
            }
            DreCaseIntoxSalivaScreen = drecaseintoxsalivascreen;
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

            _context.Attach(DreCaseIntoxSalivaScreen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseIntoxSalivaScreenExists(DreCaseIntoxSalivaScreen.DreSalivaToxResultId))
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

        private bool DreCaseIntoxSalivaScreenExists(int id)
        {
          return (_context.DreCaseIntoxSalivaScreens?.Any(e => e.DreSalivaToxResultId == id)).GetValueOrDefault();
        }
    }
}
