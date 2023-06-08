using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DREFirstIndicators
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseFirstIndicator DreCaseFirstIndicator { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreFirstIndicators == null)
            {
                return NotFound();
            }

            var drecasefirstindicator = await _context.TblOptDreFirstIndicators.FirstOrDefaultAsync(m => m.DreCaseFirstIndicatorId == id);
            if (drecasefirstindicator == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseFirstIndicator = drecasefirstindicator;
            }
            return Page();
        }
    }
}
