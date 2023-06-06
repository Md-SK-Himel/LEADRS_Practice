﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreRequested
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblOptDreRequested TblOptDreRequested { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreRequesteds == null)
            {
                return NotFound();
            }

            var tbloptdrerequested =  await _context.TblOptDreRequesteds.FirstOrDefaultAsync(m => m.DreRequestedId == id);
            if (tbloptdrerequested == null)
            {
                return NotFound();
            }
            TblOptDreRequested = tbloptdrerequested;
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

            _context.Attach(TblOptDreRequested).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblOptDreRequestedExists(TblOptDreRequested.DreRequestedId))
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

        private bool TblOptDreRequestedExists(int id)
        {
          return (_context.TblOptDreRequesteds?.Any(e => e.DreRequestedId == id)).GetValueOrDefault();
        }
    }
}
