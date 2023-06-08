﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DREReactionToLight
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ReactionToLight ReactionToLight { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreReactionToLights == null)
            {
                return NotFound();
            }

            var reactiontolight = await _context.TblOptDreReactionToLights.FirstOrDefaultAsync(m => m.ReactionToLightId == id);

            if (reactiontolight == null)
            {
                return NotFound();
            }
            else 
            {
                ReactionToLight = reactiontolight;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreReactionToLights == null)
            {
                return NotFound();
            }
            var reactiontolight = await _context.TblOptDreReactionToLights.FindAsync(id);

            if (reactiontolight != null)
            {
                ReactionToLight = reactiontolight;
                _context.TblOptDreReactionToLights.Remove(ReactionToLight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
