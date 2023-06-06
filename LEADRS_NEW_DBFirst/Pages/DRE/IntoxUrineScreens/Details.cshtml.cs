using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxUrineScreens
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseIntoxUrineScreen DreCaseIntoxUrineScreen { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxUrineScreens == null)
            {
                return NotFound();
            }

            var drecaseintoxurinescreen = await _context.DreCaseIntoxUrineScreens.FirstOrDefaultAsync(m => m.DreUrineToxResultId == id);
            if (drecaseintoxurinescreen == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseIntoxUrineScreen = drecaseintoxurinescreen;
            }
            return Page();
        }
    }
}
