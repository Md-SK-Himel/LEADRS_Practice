using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxilyzerReports
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseIntoxilyzerReport DreCaseIntoxilyzerReport { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseIntoxilyzerReports == null)
            {
                return NotFound();
            }

            var drecaseintoxilyzerreport =  await _context.DreCaseIntoxilyzerReports.FirstOrDefaultAsync(m => m.DreCaseIntoxilyzerReportId == id);
            if (drecaseintoxilyzerreport == null)
            {
                return NotFound();
            }
            DreCaseIntoxilyzerReport = drecaseintoxilyzerreport;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DreCaseIntoxilyzerReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseIntoxilyzerReportExists(DreCaseIntoxilyzerReport.DreCaseIntoxilyzerReportId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DreCaseIntoxilyzerReportExists(int id)
        {
          return (_context.DreCaseIntoxilyzerReports?.Any(e => e.DreCaseIntoxilyzerReportId == id)).GetValueOrDefault();
        }
    }
}
