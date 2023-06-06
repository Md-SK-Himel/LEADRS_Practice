using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.ToxicologyDrugs
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseToxicologyDrug DreCaseToxicologyDrug { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseToxicologyDrugs == null)
            {
                return NotFound();
            }

            var drecasetoxicologydrug = await _context.DreCaseToxicologyDrugs.FirstOrDefaultAsync(m => m.DreCaseToxDrugId == id);
            if (drecasetoxicologydrug == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseToxicologyDrug = drecasetoxicologydrug;
            }
            return Page();
        }
    }
}
