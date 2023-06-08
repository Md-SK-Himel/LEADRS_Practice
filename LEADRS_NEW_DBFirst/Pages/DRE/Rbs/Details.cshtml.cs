using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Rbs
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseRombergBalance DreCaseRombergBalance { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseRbs == null)
            {
                return NotFound();
            }

            var drecaserombergbalance = await _context.DreCaseRbs.FirstOrDefaultAsync(m => m.DreCaseRBId == id);
            if (drecaserombergbalance == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseRombergBalance = drecaserombergbalance;
            }
            return Page();
        }
    }
}
