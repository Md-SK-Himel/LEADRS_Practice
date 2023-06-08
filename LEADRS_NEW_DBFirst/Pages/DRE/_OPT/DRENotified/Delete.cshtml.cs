using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DRENotified
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreNotified DreNotified { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreNotifieds == null)
            {
                return NotFound();
            }

            var drenotified = await _context.TblOptDreNotifieds.FirstOrDefaultAsync(m => m.DreNotifiedId == id);

            if (drenotified == null)
            {
                return NotFound();
            }
            else 
            {
                DreNotified = drenotified;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreNotifieds == null)
            {
                return NotFound();
            }
            var drenotified = await _context.TblOptDreNotifieds.FindAsync(id);

            if (drenotified != null)
            {
                DreNotified = drenotified;
                _context.TblOptDreNotifieds.Remove(DreNotified);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
