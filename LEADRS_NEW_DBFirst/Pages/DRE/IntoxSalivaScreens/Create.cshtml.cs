using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.IntoxSalivaScreens
{
    public class CreateModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public CreateModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DreCaseIntoxilyzerReportId"] = new SelectList(_context.DreCaseIntoxilyzerReports, "DreCaseIntoxilyzerReportId", "DreCaseIntoxilyzerReportId");
            return Page();
        }

        [BindProperty]
        public DreCaseIntoxSalivaScreen DreCaseIntoxSalivaScreen { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreCaseIntoxSalivaScreens == null || DreCaseIntoxSalivaScreen == null)
            {
                return Page();
            }

            _context.DreCaseIntoxSalivaScreens.Add(DreCaseIntoxSalivaScreen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
