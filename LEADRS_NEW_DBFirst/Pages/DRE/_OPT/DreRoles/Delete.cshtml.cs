using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreRoles
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreRole TblOptDreRole { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreRoles == null)
            {
                return NotFound();
            }

            var tbloptdrerole = await _context.TblOptDreRoles.FirstOrDefaultAsync(m => m.DreroleId == id);

            if (tbloptdrerole == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreRole = tbloptdrerole;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreRoles == null)
            {
                return NotFound();
            }
            var tbloptdrerole = await _context.TblOptDreRoles.FindAsync(id);

            if (tbloptdrerole != null)
            {
                TblOptDreRole = tbloptdrerole;
                _context.TblOptDreRoles.Remove(TblOptDreRole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
