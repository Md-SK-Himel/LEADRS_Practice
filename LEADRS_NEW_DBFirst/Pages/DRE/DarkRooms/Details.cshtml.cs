﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.DarkRooms
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseDarkRoom DreCaseDarkRoom { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesDarkRooms == null)
            {
                return NotFound();
            }

            var drecasedarkroom = await _context.DreCasesDarkRooms.FirstOrDefaultAsync(m => m.DreCaseDarkRoomId == id);
            if (drecasedarkroom == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseDarkRoom = drecasedarkroom;
            }
            return Page();
        }
    }
}
