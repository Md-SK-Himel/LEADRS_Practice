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

namespace LEADRS_NEW_DBFirst.Pages.DRE.Notes
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseNote DreCaseNote { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseNotes == null)
            {
                return NotFound();
            }

            var drecasenote =  await _context.DreCaseNotes.FirstOrDefaultAsync(m => m.DreCaseNoteId == id);
            if (drecasenote == null)
            {
                return NotFound();
            }
            DreCaseNote = drecasenote;
           ViewData["DreCaseId"] = new SelectList(_context.DreCases, "DRECaseId", "DreNumber");
           ViewData["DreCaseNoteTypeId"] = new SelectList(_context.DreCaseNoteTypes, "DreCaseNoteTypeId", "DreCaseNoteTypeId");
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

            _context.Attach(DreCaseNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseNoteExists(DreCaseNote.DreCaseNoteId))
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

        private bool DreCaseNoteExists(int id)
        {
          return (_context.DreCaseNotes?.Any(e => e.DreCaseNoteId == id)).GetValueOrDefault();
        }
    }
}
