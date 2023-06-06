using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.NoteTypes
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseNoteType DreCaseNoteType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseNoteTypes == null)
            {
                return NotFound();
            }

            var drecasenotetype = await _context.DreCaseNoteTypes.FirstOrDefaultAsync(m => m.DreCaseNoteTypeId == id);

            if (drecasenotetype == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseNoteType = drecasenotetype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseNoteTypes == null)
            {
                return NotFound();
            }
            var drecasenotetype = await _context.DreCaseNoteTypes.FindAsync(id);

            if (drecasenotetype != null)
            {
                DreCaseNoteType = drecasenotetype;
                _context.DreCaseNoteTypes.Remove(DreCaseNoteType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
