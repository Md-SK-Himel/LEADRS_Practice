using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreReactionToLight
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreReactionToLight TblOptDreReactionToLight { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreReactionToLights == null)
            {
                return NotFound();
            }

            var tbloptdrereactiontolight = await _context.TblOptDreReactionToLights.FirstOrDefaultAsync(m => m.ReactionToLightId == id);

            if (tbloptdrereactiontolight == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreReactionToLight = tbloptdrereactiontolight;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreReactionToLights == null)
            {
                return NotFound();
            }
            var tbloptdrereactiontolight = await _context.TblOptDreReactionToLights.FindAsync(id);

            if (tbloptdrereactiontolight != null)
            {
                TblOptDreReactionToLight = tbloptdrereactiontolight;
                _context.TblOptDreReactionToLights.Remove(TblOptDreReactionToLight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
