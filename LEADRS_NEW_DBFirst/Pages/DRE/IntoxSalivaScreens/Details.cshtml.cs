using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxSalivaScreens
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseIntoxSalivaScreen DreCaseIntoxSalivaScreen { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxSalivaScreens == null)
            {
                return NotFound();
            }

            var drecaseintoxsalivascreen = await _context.DreCaseIntoxSalivaScreens.FirstOrDefaultAsync(m => m.DreSalivaToxResultId == id);
            if (drecaseintoxsalivascreen == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseIntoxSalivaScreen = drecaseintoxsalivascreen;
            }
            return Page();
        }
    }
}
