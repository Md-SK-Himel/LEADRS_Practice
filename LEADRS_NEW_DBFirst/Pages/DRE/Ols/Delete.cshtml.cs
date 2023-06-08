using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

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
      public DreCaseOneLegStand DreCaseOneLegStand { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseOls == null)
            {
                return NotFound();
            }

            var drecaseonelegstand = await _context.DreCaseOls.FirstOrDefaultAsync(m => m.DreCaseOLSId == id);

            if (drecaseonelegstand == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseOneLegStand = drecaseonelegstand;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseOls == null)
            {
                return NotFound();
            }
            var drecaseonelegstand = await _context.DreCaseOls.FindAsync(id);

            if (drecaseonelegstand != null)
            {
                DreCaseOneLegStand = drecaseonelegstand;
                _context.DreCaseOls.Remove(DreCaseOneLegStand);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
