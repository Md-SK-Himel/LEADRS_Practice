﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Obs
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCasesObs DreCasesObs { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesObs == null)
            {
                return NotFound();
            }

            var drecasesobs = await _context.DreCasesObs.FirstOrDefaultAsync(m => m.DreCaseObservationsId == id);
            if (drecasesobs == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesObs = drecasesobs;
            }
            return Page();
        }
    }
}
