﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DRERequested
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreRequested DreRequested { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreRequesteds == null)
            {
                return NotFound();
            }

            var drerequested = await _context.TblOptDreRequesteds.FirstOrDefaultAsync(m => m.DreRequestedId == id);

            if (drerequested == null)
            {
                return NotFound();
            }
            else 
            {
                DreRequested = drerequested;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreRequesteds == null)
            {
                return NotFound();
            }
            var drerequested = await _context.TblOptDreRequesteds.FindAsync(id);

            if (drerequested != null)
            {
                DreRequested = drerequested;
                _context.TblOptDreRequesteds.Remove(DreRequested);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
