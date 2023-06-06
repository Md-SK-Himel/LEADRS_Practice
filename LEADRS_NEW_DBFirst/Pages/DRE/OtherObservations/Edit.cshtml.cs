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

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherObservations
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseOtherObservation DreCaseOtherObservation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseOtherObservations == null)
            {
                return NotFound();
            }

            var drecaseotherobservation =  await _context.DreCaseOtherObservations.FirstOrDefaultAsync(m => m.OtherObservationId == id);
            if (drecaseotherobservation == null)
            {
                return NotFound();
            }
            DreCaseOtherObservation = drecaseotherobservation;
           ViewData["DreCaseId"] = new SelectList(_context.DreCases, "DrecaseId", "DrecaseId");
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

            _context.Attach(DreCaseOtherObservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseOtherObservationExists(DreCaseOtherObservation.OtherObservationId))
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

        private bool DreCaseOtherObservationExists(int id)
        {
          return (_context.DreCaseOtherObservations?.Any(e => e.OtherObservationId == id)).GetValueOrDefault();
        }
    }
}
