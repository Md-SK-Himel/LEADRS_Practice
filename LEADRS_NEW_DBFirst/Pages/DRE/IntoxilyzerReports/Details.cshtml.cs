using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxilyzerReports
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseIntoxilyzerReport DreCaseIntoxilyzerReport { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxilyzerReports == null)
            {
                return NotFound();
            }

            var drecaseintoxilyzerreport = await _context.DreCaseIntoxilyzerReports.FirstOrDefaultAsync(m => m.DreCaseIntoxilyzerReportId == id);
            if (drecaseintoxilyzerreport == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseIntoxilyzerReport = drecaseintoxilyzerreport;
            }
            return Page();
        }
    }
}
