using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DRESecondIndicators
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseSecondIndicator DreCaseSecondIndicator { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreSecondIndicators == null)
            {
                return NotFound();
            }

            var drecasesecondindicator = await _context.TblOptDreSecondIndicators.FirstOrDefaultAsync(m => m.DreCaseSecondIndicatorId == id);
            if (drecasesecondindicator == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseSecondIndicator = drecasesecondindicator;
            }
            return Page();
        }
    }
}
