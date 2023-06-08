﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Obs
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseObservations DreCaseObservations { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesObs == null)
            {
                return NotFound();
            }

            var drecaseobservations = await _context.DreCasesObs.FirstOrDefaultAsync(m => m.DreCaseObservationsId == id);

            if (drecaseobservations == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseObservations = drecaseobservations;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesObs == null)
            {
                return NotFound();
            }
            var drecaseobservations = await _context.DreCasesObs.FindAsync(id);

            if (drecaseobservations != null)
            {
                DreCaseObservations = drecaseobservations;
                _context.DreCasesObs.Remove(DreCaseObservations);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
