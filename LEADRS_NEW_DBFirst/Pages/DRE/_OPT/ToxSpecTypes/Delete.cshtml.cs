using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.ToxSpecTypes
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseToxSpecType DreCaseToxSpecType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptToxSpecTypes == null)
            {
                return NotFound();
            }

            var drecasetoxspectype = await _context.TblOptToxSpecTypes.FirstOrDefaultAsync(m => m.ToxSpecTypeId == id);

            if (drecasetoxspectype == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseToxSpecType = drecasetoxspectype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptToxSpecTypes == null)
            {
                return NotFound();
            }
            var drecasetoxspectype = await _context.TblOptToxSpecTypes.FindAsync(id);

            if (drecasetoxspectype != null)
            {
                DreCaseToxSpecType = drecasetoxspectype;
                _context.TblOptToxSpecTypes.Remove(DreCaseToxSpecType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
