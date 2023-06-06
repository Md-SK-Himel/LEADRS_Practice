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

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherOfficers
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCasesOtherOfficer DreCasesOtherOfficer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOtherOfficers == null)
            {
                return NotFound();
            }

            var drecasesotherofficer =  await _context.DreCasesOtherOfficers.FirstOrDefaultAsync(m => m.OtherOfficerId == id);
            if (drecasesotherofficer == null)
            {
                return NotFound();
            }
            DreCasesOtherOfficer = drecasesotherofficer;
           ViewData["DreCaseId"] = new SelectList(_context.DreCases, "DrecaseId", "DrecaseId");
           ViewData["DreRoleId"] = new SelectList(_context.TblOptDreRoles, "DreroleId", "DreroleId");
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

            _context.Attach(DreCasesOtherOfficer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCasesOtherOfficerExists(DreCasesOtherOfficer.OtherOfficerId))
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

        private bool DreCasesOtherOfficerExists(int id)
        {
          return (_context.DreCasesOtherOfficers?.Any(e => e.OtherOfficerId == id)).GetValueOrDefault();
        }
    }
}
