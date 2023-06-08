using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Notes
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
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

            var drecasenote = await _context.DreCaseNotes.FirstOrDefaultAsync(m => m.DreCaseNoteId == id);

            if (drecasenote == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseNote = drecasenote;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseNotes == null)
            {
                return NotFound();
            }
            var drecasenote = await _context.DreCaseNotes.FindAsync(id);

            if (drecasenote != null)
            {
                DreCaseNote = drecasenote;
                _context.DreCaseNotes.Remove(DreCaseNote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
