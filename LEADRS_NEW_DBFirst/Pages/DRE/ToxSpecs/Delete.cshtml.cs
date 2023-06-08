using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.ToxSpecs
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseToxSpec DreCaseToxSpec { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseToxSpecs == null)
            {
                return NotFound();
            }

            var drecasetoxspec = await _context.DreCaseToxSpecs.FirstOrDefaultAsync(m => m.DreCaseToxSpecId == id);

            if (drecasetoxspec == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseToxSpec = drecasetoxspec;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseToxSpecs == null)
            {
                return NotFound();
            }
            var drecasetoxspec = await _context.DreCaseToxSpecs.FindAsync(id);

            if (drecasetoxspec != null)
            {
                DreCaseToxSpec = drecasetoxspec;
                _context.DreCaseToxSpecs.Remove(DreCaseToxSpec);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
