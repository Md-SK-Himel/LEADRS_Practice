using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Pics
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasePic DreCasePic { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasePics == null)
            {
                return NotFound();
            }

            var drecasepic = await _context.DreCasePics.FirstOrDefaultAsync(m => m.DreCasePictureId == id);

            if (drecasepic == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasePic = drecasepic;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasePics == null)
            {
                return NotFound();
            }
            var drecasepic = await _context.DreCasePics.FindAsync(id);

            if (drecasepic != null)
            {
                DreCasePic = drecasepic;
                _context.DreCasePics.Remove(DreCasePic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
