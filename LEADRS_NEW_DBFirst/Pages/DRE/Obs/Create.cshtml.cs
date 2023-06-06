﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Obs
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
        ViewData["DreCaseId"] = new SelectList(_context.DreCases, "DrecaseId", "DrecaseId");
            return Page();
        }

        [BindProperty]
        public DreCasesObs DreCasesObs { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreCasesObs == null || DreCasesObs == null)
            {
                return Page();
            }

            _context.DreCasesObs.Add(DreCasesObs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
