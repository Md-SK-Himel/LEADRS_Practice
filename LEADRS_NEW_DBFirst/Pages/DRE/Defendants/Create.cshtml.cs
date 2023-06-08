using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Defendants
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
        ViewData["ArrestingOfficerTypeId"] = new SelectList(_context.TblOptAoTypes, "ArrestingOfficerTypeId", "ArrestingOfficerTypeId");
            return Page();
        }

        [BindProperty]
        public DreCaseDefendant DreCaseDefendant { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreDefendants == null || DreCaseDefendant == null)
            {
                return Page();
            }

            _context.DreDefendants.Add(DreCaseDefendant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
