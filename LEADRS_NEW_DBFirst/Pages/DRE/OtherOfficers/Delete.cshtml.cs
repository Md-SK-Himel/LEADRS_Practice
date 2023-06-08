using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherOfficers
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseOtherOfficer DreCaseOtherOfficer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOtherOfficers == null)
            {
                return NotFound();
            }

            var drecaseotherofficer = await _context.DreCasesOtherOfficers.FirstOrDefaultAsync(m => m.OtherOfficerId == id);

            if (drecaseotherofficer == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseOtherOfficer = drecaseotherofficer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesOtherOfficers == null)
            {
                return NotFound();
            }
            var drecaseotherofficer = await _context.DreCasesOtherOfficers.FindAsync(id);

            if (drecaseotherofficer != null)
            {
                DreCaseOtherOfficer = drecaseotherofficer;
                _context.DreCasesOtherOfficers.Remove(DreCaseOtherOfficer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
