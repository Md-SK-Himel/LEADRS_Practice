﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Images
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
        public DreCaseImage DreCaseImage { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DreCaseImages == null || DreCaseImage == null)
            {
                return Page();
            }

            _context.DreCaseImages.Add(DreCaseImage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
