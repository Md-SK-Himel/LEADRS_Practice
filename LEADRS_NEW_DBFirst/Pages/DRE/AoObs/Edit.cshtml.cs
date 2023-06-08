using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoObs
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseArrestingOfficerObservation DreCaseArrestingOfficerObservation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesAoObs == null)
            {
                return NotFound();
            }

            var drecasearrestingofficerobservation =  await _context.DreCasesAoObs.FirstOrDefaultAsync(m => m.ObservationId == id);
            if (drecasearrestingofficerobservation == null)
            {
                return NotFound();
            }
            DreCaseArrestingOfficerObservation = drecasearrestingofficerobservation;
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

            _context.Attach(DreCaseArrestingOfficerObservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseArrestingOfficerObservationExists(DreCaseArrestingOfficerObservation.ObservationId))
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

        private bool DreCaseArrestingOfficerObservationExists(int id)
        {
          return (_context.DreCasesAoObs?.Any(e => e.ObservationId == id)).GetValueOrDefault();
        }
    }
}
