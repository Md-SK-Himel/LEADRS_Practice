using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Cases
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
        ViewData["DreTypeId"] = new SelectList(_context.TblOptDreTypes, "DRETypeId", "DRETypeId");
        ViewData["DreNotifiedId"] = new SelectList(_context.TblOptDreNotifieds, "DreNotifiedId", "DreNotifiedId");
        ViewData["DreRequestedId"] = new SelectList(_context.TblOptDreRequesteds, "DreRequestedId", "DreRequestedId");
        ViewData["DreRoleId"] = new SelectList(_context.TblOptDreRoles, "DRERoleId", "DRERoleId");
        ViewData["StatusId"] = new SelectList(_context.TblOptDreCaseStatuses, "DRECaseStatusId", "DRECaseStatusId");
            return Page();
        }

        [BindProperty]
        public DRECase DRECase { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreCases == null || DRECase == null)
            {
                return Page();
            }

            _context.DreCases.Add(DRECase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
