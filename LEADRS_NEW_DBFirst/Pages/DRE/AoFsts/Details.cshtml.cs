using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoFsts
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseAoFst DreCaseAoFst { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoFsts == null)
            {
                return NotFound();
            }

            var drecaseaofst = await _context.DreCaseAoFsts.FirstOrDefaultAsync(m => m.ArrestingOfficerFstid == id);
            if (drecaseaofst == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseAoFst = drecaseaofst;
            }
            return Page();
        }
    }
}
