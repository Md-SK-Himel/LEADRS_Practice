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

namespace LEADRS_NEW_DBFirst.Pages.DRE.ToxSpecs
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseToxSpec DreCaseToxSpec { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseToxSpecs == null)
            {
                return NotFound();
            }

            var drecasetoxspec =  await _context.DreCaseToxSpecs.FirstOrDefaultAsync(m => m.DreCaseToxSpecId == id);
            if (drecasetoxspec == null)
            {
                return NotFound();
            }
            DreCaseToxSpec = drecasetoxspec;
           ViewData["DreCaseId"] = new SelectList(_context.DreCases, "DrecaseId", "DrecaseId");
           ViewData["ToxSpecTypeId"] = new SelectList(_context.TblOptToxSpecTypes, "ToxSpecTypeId", "ToxSpecTypeId");
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

            _context.Attach(DreCaseToxSpec).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseToxSpecExists(DreCaseToxSpec.DreCaseToxSpecId))
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

        private bool DreCaseToxSpecExists(int id)
        {
          return (_context.DreCaseToxSpecs?.Any(e => e.DreCaseToxSpecId == id)).GetValueOrDefault();
        }
    }
}
