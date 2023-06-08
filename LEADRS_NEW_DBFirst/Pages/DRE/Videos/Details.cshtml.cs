using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Videos
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

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
    }
}
