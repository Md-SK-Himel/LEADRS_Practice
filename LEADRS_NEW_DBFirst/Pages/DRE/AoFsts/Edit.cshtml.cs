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

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoFsts
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseAoFst DreCaseAoFst { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoFsts == null)
            {
                return NotFound();
            }

            var drecaseaofst =  await _context.DreCaseAoFsts.FirstOrDefaultAsync(m => m.ArrestingOfficerFstid == id);
            if (drecaseaofst == null)
            {
                return NotFound();
            }
            DreCaseAoFst = drecaseaofst;
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

            _context.Attach(DreCaseAoFst).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseAoFstExists(DreCaseAoFst.ArrestingOfficerFstid))
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

        private bool DreCaseAoFstExists(int id)
        {
          return (_context.DreCaseAoFsts?.Any(e => e.ArrestingOfficerFstid == id)).GetValueOrDefault();
        }
    }
}
