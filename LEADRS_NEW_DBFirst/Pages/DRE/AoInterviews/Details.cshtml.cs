using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.AoInterviews
{
    public class DetailsModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DetailsModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

      public DreCaseArrestingOfficerInterview DreCaseArrestingOfficerInterview { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseAoInterviews == null)
            {
                return NotFound();
            }

            var drecasearrestingofficerinterview = await _context.DreCaseAoInterviews.FirstOrDefaultAsync(m => m.InterviewId == id);
            if (drecasearrestingofficerinterview == null)
            {
                return NotFound();
            }
            else 
            {
                DreCaseArrestingOfficerInterview = drecasearrestingofficerinterview;
            }
            return Page();
        }
    }
}
