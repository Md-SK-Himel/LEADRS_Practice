using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Ftns
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseFingerToNose DreCaseFingerToNose { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesFtns == null)
            {
                return NotFound();
            }

            var drecasefingertonose = await _context.DreCasesFtns.FirstOrDefaultAsync(m => m.DreCaseFingerToNoseId == id);
            if (drecasefingertonose == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseFingerToNose = drecasefingertonose;
            }
            return Page();
        }
    }
}
