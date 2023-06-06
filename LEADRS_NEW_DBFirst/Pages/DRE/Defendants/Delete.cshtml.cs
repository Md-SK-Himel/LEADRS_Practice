using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Defendants
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreDefendant DreDefendant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreDefendants == null)
            {
                return NotFound();
            }

            var dredefendant = await _context.DreDefendants.FirstOrDefaultAsync(m => m.DreCaseDefendantId == id);

            if (dredefendant == null)
            {
                return NotFound();
            }
            else 
            {
                DreDefendant = dredefendant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreDefendants == null)
            {
                return NotFound();
            }
            var dredefendant = await _context.DreDefendants.FindAsync(id);

            if (dredefendant != null)
            {
                DreDefendant = dredefendant;
                _context.DreDefendants.Remove(DreDefendant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
