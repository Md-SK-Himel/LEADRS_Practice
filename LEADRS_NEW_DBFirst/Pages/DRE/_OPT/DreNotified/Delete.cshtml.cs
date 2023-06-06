using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreNotified
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreNotified TblOptDreNotified { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreNotifieds == null)
            {
                return NotFound();
            }

            var tbloptdrenotified = await _context.TblOptDreNotifieds.FirstOrDefaultAsync(m => m.DreNotifiedId == id);

            if (tbloptdrenotified == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreNotified = tbloptdrenotified;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreNotifieds == null)
            {
                return NotFound();
            }
            var tbloptdrenotified = await _context.TblOptDreNotifieds.FindAsync(id);

            if (tbloptdrenotified != null)
            {
                TblOptDreNotified = tbloptdrenotified;
                _context.TblOptDreNotifieds.Remove(TblOptDreNotified);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
