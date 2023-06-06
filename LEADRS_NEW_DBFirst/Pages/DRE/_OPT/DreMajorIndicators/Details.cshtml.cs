using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreMajorIndicators
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public TblOptDreMajorIndicator TblOptDreMajorIndicator { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreMajorIndicators == null)
            {
                return NotFound();
            }

            var tbloptdremajorindicator = await _context.TblOptDreMajorIndicators.FirstOrDefaultAsync(m => m.DreMajorIndicatorId == id);
            if (tbloptdremajorindicator == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreMajorIndicator = tbloptdremajorindicator;
            }
            return Page();
        }
    }
}
