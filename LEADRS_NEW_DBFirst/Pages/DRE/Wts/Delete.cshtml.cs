using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Wts
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseWt DreCaseWt { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseWts == null)
            {
                return NotFound();
            }

            var drecasewt = await _context.DreCaseWts.FirstOrDefaultAsync(m => m.DreCaseWtid == id);

            if (drecasewt == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseWt = drecasewt;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseWts == null)
            {
                return NotFound();
            }
            var drecasewt = await _context.DreCaseWts.FindAsync(id);

            if (drecasewt != null)
            {
                DreCaseWt = drecasewt;
                _context.DreCaseWts.Remove(DreCaseWt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
