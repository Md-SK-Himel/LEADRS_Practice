using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasePage DreCasePage { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasePages == null)
            {
                return NotFound();
            }

            var drecasepage = await _context.DreCasePages.FirstOrDefaultAsync(m => m.DreCasePageId == id);

            if (drecasepage == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasePage = drecasepage;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasePages == null)
            {
                return NotFound();
            }
            var drecasepage = await _context.DreCasePages.FindAsync(id);

            if (drecasepage != null)
            {
                DreCasePage = drecasepage;
                _context.DreCasePages.Remove(DreCasePage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
