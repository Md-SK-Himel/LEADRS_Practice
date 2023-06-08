using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DRERoles
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DRERole DRERole { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreRoles == null)
            {
                return NotFound();
            }

            var drerole = await _context.TblOptDreRoles.FirstOrDefaultAsync(m => m.DRERoleId == id);

            if (drerole == null)
            {
                return NotFound();
            }
            else 
            {
                DRERole = drerole;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreRoles == null)
            {
                return NotFound();
            }
            var drerole = await _context.TblOptDreRoles.FindAsync(id);

            if (drerole != null)
            {
                DRERole = drerole;
                _context.TblOptDreRoles.Remove(DRERole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
