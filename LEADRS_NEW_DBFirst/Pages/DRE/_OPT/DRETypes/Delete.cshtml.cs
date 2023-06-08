using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DRETypes
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DREType DREType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreTypes == null)
            {
                return NotFound();
            }

            var dretype = await _context.TblOptDreTypes.FirstOrDefaultAsync(m => m.DRETypeId == id);

            if (dretype == null)
            {
                return NotFound();
            }
            else 
            {
                DREType = dretype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreTypes == null)
            {
                return NotFound();
            }
            var dretype = await _context.TblOptDreTypes.FindAsync(id);

            if (dretype != null)
            {
                DREType = dretype;
                _context.TblOptDreTypes.Remove(DREType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
