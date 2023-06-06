using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Hgns
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseHgn DreCaseHgn { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseHgns == null)
            {
                return NotFound();
            }

            var drecasehgn = await _context.DreCaseHgns.FirstOrDefaultAsync(m => m.DreCaseHgnId == id);
            if (drecasehgn == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseHgn = drecasehgn;
            }
            return Page();
        }
    }
}
