using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Images
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseImage DreCaseImage { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseImages == null)
            {
                return NotFound();
            }

            var drecaseimage = await _context.DreCaseImages.FirstOrDefaultAsync(m => m.DreCaseImageId == id);
            if (drecaseimage == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseImage = drecaseimage;
            }
            return Page();
        }
    }
}
