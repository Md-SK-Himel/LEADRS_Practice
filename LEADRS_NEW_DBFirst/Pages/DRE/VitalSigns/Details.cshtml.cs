using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.VitalSigns
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseVitalSign DreCaseVitalSign { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesVitalSigns == null)
            {
                return NotFound();
            }

            var drecasevitalsign = await _context.DreCasesVitalSigns.FirstOrDefaultAsync(m => m.DreCaseVitalSignId == id);
            if (drecasevitalsign == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseVitalSign = drecasevitalsign;
            }
            return Page();
        }
    }
}
