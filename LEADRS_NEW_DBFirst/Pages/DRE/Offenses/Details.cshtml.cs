using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Offenses
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCasesOffense DreCasesOffense { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOffenses == null)
            {
                return NotFound();
            }

            var drecasesoffense = await _context.DreCasesOffenses.FirstOrDefaultAsync(m => m.DreCaseOffenseId == id);
            if (drecasesoffense == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesOffense = drecasesoffense;
            }
            return Page();
        }
    }
}
