using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE_Pages
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCase DreCase { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCases == null)
            {
                return NotFound();
            }

            var drecase =  await _context.DreCases.FirstOrDefaultAsync(m => m.DrecaseId == id);
            if (drecase == null)
            {
                return NotFound();
            }
            DreCase = drecase;
           ViewData["DreNotifiedId"] = new SelectList(_context.TblOptDreNotifieds, "DreNotifiedId", "DreNotifiedId");
           ViewData["DreRequestedId"] = new SelectList(_context.TblOptDreRequesteds, "DreRequestedId", "DreRequestedId");
           ViewData["DreRoleId"] = new SelectList(_context.TblOptDreRoles, "DreroleId", "DreroleId");
           ViewData["DreTypeId"] = new SelectList(_context.TblOptDreTypes, "DretypeId", "DretypeId");
           ViewData["StatusId"] = new SelectList(_context.TblOptDreCaseStatuses, "DrecaseStatusId", "DrecaseStatusId");
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

            _context.Attach(DreCase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseExists(DreCase.DrecaseId))
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

        private bool DreCaseExists(int id)
        {
          return (_context.DreCases?.Any(e => e.DrecaseId == id)).GetValueOrDefault();
        }
    }
}
