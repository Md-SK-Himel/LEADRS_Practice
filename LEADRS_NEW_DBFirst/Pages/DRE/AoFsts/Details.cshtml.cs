using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoFsts
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseArrestingOfficerFST DreCaseArrestingOfficerFST { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoFsts == null)
            {
                return NotFound();
            }

            var drecasearrestingofficerfst = await _context.DreCaseAoFsts.FirstOrDefaultAsync(m => m.ArrestingOfficerFSTId == id);
            if (drecasearrestingofficerfst == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseArrestingOfficerFST = drecasearrestingofficerfst;
            }
            return Page();
        }
    }
}
