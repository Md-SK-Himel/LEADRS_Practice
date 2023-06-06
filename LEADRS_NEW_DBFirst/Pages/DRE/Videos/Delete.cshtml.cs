using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Videos
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCaseVideo DreCaseVideo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseVideos == null)
            {
                return NotFound();
            }

            var drecasevideo = await _context.DreCaseVideos.FirstOrDefaultAsync(m => m.DreCaseVideoId == id);

            if (drecasevideo == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseVideo = drecasevideo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCaseVideos == null)
            {
                return NotFound();
            }
            var drecasevideo = await _context.DreCaseVideos.FindAsync(id);

            if (drecasevideo != null)
            {
                DreCaseVideo = drecasevideo;
                _context.DreCaseVideos.Remove(DreCaseVideo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
