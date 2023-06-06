using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherOfficers
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCasesOtherOfficer DreCasesOtherOfficer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesOtherOfficers == null)
            {
                return NotFound();
            }

            var drecasesotherofficer = await _context.DreCasesOtherOfficers.FirstOrDefaultAsync(m => m.OtherOfficerId == id);
            if (drecasesotherofficer == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesOtherOfficer = drecasesotherofficer;
            }
            return Page();
        }
    }
}
