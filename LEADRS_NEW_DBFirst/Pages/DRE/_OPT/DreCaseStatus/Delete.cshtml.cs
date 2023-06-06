using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DreCaseStatus
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TblOptDreCaseStatus TblOptDreCaseStatus { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreCaseStatuses == null)
            {
                return NotFound();
            }

            var tbloptdrecasestatus = await _context.TblOptDreCaseStatuses.FirstOrDefaultAsync(m => m.DrecaseStatusId == id);

            if (tbloptdrecasestatus == null)
            {
                return NotFound();
            }
            else 
            {
                TblOptDreCaseStatus = tbloptdrecasestatus;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreCaseStatuses == null)
            {
                return NotFound();
            }
            var tbloptdrecasestatus = await _context.TblOptDreCaseStatuses.FindAsync(id);

            if (tbloptdrecasestatus != null)
            {
                TblOptDreCaseStatus = tbloptdrecasestatus;
                _context.TblOptDreCaseStatuses.Remove(TblOptDreCaseStatus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
