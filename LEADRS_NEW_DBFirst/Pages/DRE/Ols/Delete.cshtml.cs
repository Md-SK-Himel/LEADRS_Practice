using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Ols
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseOls DreCaseOls { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseOls == null)
            {
                return NotFound();
            }

            var drecaseols = await _context.DreCaseOls.FirstOrDefaultAsync(m => m.DreCaseOlsid == id);

            if (drecaseols == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseOls = drecaseols;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseOls == null)
            {
                return NotFound();
            }
            var drecaseols = await _context.DreCaseOls.FindAsync(id);

            if (drecaseols != null)
            {
                DreCaseOls = drecaseols;
                _context.DreCaseOls.Remove(DreCaseOls);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
