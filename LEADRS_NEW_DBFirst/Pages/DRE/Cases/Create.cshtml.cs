using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE_Pages
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
        ViewData["DreNotifiedId"] = new SelectList(_context.TblOptDreNotifieds, "DreNotifiedId", "DreNotifiedId");
        ViewData["DreRequestedId"] = new SelectList(_context.TblOptDreRequesteds, "DreRequestedId", "DreRequestedId");
        ViewData["DreRoleId"] = new SelectList(_context.TblOptDreRoles, "DreroleId", "DreroleId");
        ViewData["DreTypeId"] = new SelectList(_context.TblOptDreTypes, "DretypeId", "DretypeId");
        ViewData["StatusId"] = new SelectList(_context.TblOptDreCaseStatuses, "DrecaseStatusId", "DrecaseStatusId");
            return Page();
        }

        [BindProperty]
        public DreCase DreCase { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreCases == null || DreCase == null)
            {
                return Page();
            }

            _context.DreCases.Add(DreCase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
