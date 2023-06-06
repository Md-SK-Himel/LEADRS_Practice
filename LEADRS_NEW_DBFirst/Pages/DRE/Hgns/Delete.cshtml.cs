using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Hgns
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseHgn DreCaseHgn { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseHgns == null)
            {
                return NotFound();
            }

            var drecasehgn = await _context.DreCaseHgns.FirstOrDefaultAsync(m => m.DreCaseHgnId == id);

            if (drecasehgn == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseHgn = drecasehgn;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseHgns == null)
            {
                return NotFound();
            }
            var drecasehgn = await _context.DreCaseHgns.FindAsync(id);

            if (drecasehgn != null)
            {
                DreCaseHgn = drecasehgn;
                _context.DreCaseHgns.Remove(DreCaseHgn);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
