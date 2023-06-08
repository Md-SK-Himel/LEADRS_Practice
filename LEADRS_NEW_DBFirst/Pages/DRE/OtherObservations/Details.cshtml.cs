using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherObservations
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseOtherObservation DreCaseOtherObservation { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseOtherObservations == null)
            {
                return NotFound();
            }

            var drecaseotherobservation = await _context.DreCaseOtherObservations.FirstOrDefaultAsync(m => m.OtherObservationId == id);
            if (drecaseotherobservation == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseOtherObservation = drecaseotherobservation;
            }
            return Page();
        }
    }
}
