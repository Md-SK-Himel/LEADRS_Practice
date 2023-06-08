using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Defendants
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseDefendant DreCaseDefendant { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreDefendants == null)
            {
                return NotFound();
            }

            var drecasedefendant = await _context.DreDefendants.FirstOrDefaultAsync(m => m.DreCaseDefendantId == id);
            if (drecasedefendant == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseDefendant = drecasedefendant;
            }
            return Page();
        }
    }
}
