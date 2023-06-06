using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Ftns
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasesFtn DreCasesFtn { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesFtns == null)
            {
                return NotFound();
            }

            var drecasesftn = await _context.DreCasesFtns.FirstOrDefaultAsync(m => m.DreCaseFingerToNoseId == id);

            if (drecasesftn == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesFtn = drecasesftn;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesFtns == null)
            {
                return NotFound();
            }
            var drecasesftn = await _context.DreCasesFtns.FindAsync(id);

            if (drecasesftn != null)
            {
                DreCasesFtn = drecasesftn;
                _context.DreCasesFtns.Remove(DreCasesFtn);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
