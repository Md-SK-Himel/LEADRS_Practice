﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Wts
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseWalkTurn DreCaseWalkTurn { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseWts == null)
            {
                return NotFound();
            }

            var drecasewalkturn = await _context.DreCaseWts.FirstOrDefaultAsync(m => m.DreCaseWTId == id);
            if (drecasewalkturn == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseWalkTurn = drecasewalkturn;
            }
            return Page();
        }
    }
}
