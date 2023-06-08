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

namespace LEADRS_NEW_DBFirst.Pages.DRE.Offenses
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseOffense DreCaseOffense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOffenses == null)
            {
                return NotFound();
            }

            var drecaseoffense =  await _context.DreCasesOffenses.FirstOrDefaultAsync(m => m.DreCaseOffenseId == id);
            if (drecaseoffense == null)
            {
                return NotFound();
            }
            DreCaseOffense = drecaseoffense;
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

            _context.Attach(DreCaseOffense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseOffenseExists(DreCaseOffense.DreCaseOffenseId))
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

        private bool DreCaseOffenseExists(int id)
        {
          return (_context.DreCasesOffenses?.Any(e => e.DreCaseOffenseId == id)).GetValueOrDefault();
        }
    }
}
