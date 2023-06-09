﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.NoteTypes
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DreCaseNoteType DreCaseNoteType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCaseNoteTypes == null)
            {
                return NotFound();
            }

            var drecasenotetype =  await _context.DreCaseNoteTypes.FirstOrDefaultAsync(m => m.DreCaseNoteTypeId == id);
            if (drecasenotetype == null)
            {
                return NotFound();
            }
            DreCaseNoteType = drecasenotetype;
           ViewData["DreCasePageId"] = new SelectList(_context.DreCasePages, "DreCasePageId", "DreCasePageId");
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

            _context.Attach(DreCaseNoteType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DreCaseNoteTypeExists(DreCaseNoteType.DreCaseNoteTypeId))
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

        private bool DreCaseNoteTypeExists(int id)
        {
          return (_context.DreCaseNoteTypes?.Any(e => e.DreCaseNoteTypeId == id)).GetValueOrDefault();
        }
    }
}
