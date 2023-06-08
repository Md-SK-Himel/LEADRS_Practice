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

namespace LEADRS_NEW_DBFirst.Pages.DRE.Defendants
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseDefendant DreCaseDefendant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreDefendants == null)
            {
                return NotFound();
            }

            var drecasedefendant =  await _context.DreDefendants.FirstOrDefaultAsync(m => m.DreCaseDefendantId == id);
            if (drecasedefendant == null)
            {
                return NotFound();
            }
            DreCaseDefendant = drecasedefendant;
           ViewData["ArrestingOfficerTypeId"] = new SelectList(_context.TblOptAoTypes, "ArrestingOfficerTypeId", "ArrestingOfficerTypeId");
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

            _context.Attach(DreCaseDefendant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseDefendantExists(DreCaseDefendant.DreCaseDefendantId))
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

        private bool DreCaseDefendantExists(int id)
        {
          return (_context.DreDefendants?.Any(e => e.DreCaseDefendantId == id)).GetValueOrDefault();
        }
    }
}
