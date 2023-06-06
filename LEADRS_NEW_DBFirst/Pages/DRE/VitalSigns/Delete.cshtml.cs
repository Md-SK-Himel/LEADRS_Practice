using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.VitalSigns
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasesVitalSign DreCasesVitalSign { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesVitalSigns == null)
            {
                return NotFound();
            }

            var drecasesvitalsign = await _context.DreCasesVitalSigns.FirstOrDefaultAsync(m => m.DreCaseVitalSignId == id);

            if (drecasesvitalsign == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesVitalSign = drecasesvitalsign;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesVitalSigns == null)
            {
                return NotFound();
            }
            var drecasesvitalsign = await _context.DreCasesVitalSigns.FindAsync(id);

            if (drecasesvitalsign != null)
            {
                DreCasesVitalSign = drecasesvitalsign;
                _context.DreCasesVitalSigns.Remove(DreCasesVitalSign);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
