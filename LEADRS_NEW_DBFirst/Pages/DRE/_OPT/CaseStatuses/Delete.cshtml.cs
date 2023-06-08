using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.CaseStatuses
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DRECaseStatus DRECaseStatus { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDreCaseStatuses == null)
            {
                return NotFound();
            }

            var drecasestatus = await _context.TblOptDreCaseStatuses.FirstOrDefaultAsync(m => m.DRECaseStatusId == id);

            if (drecasestatus == null)
            {
                return NotFound();
            }
            else 
            {
                DRECaseStatus = drecasestatus;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDreCaseStatuses == null)
            {
                return NotFound();
            }
            var drecasestatus = await _context.TblOptDreCaseStatuses.FindAsync(id);

            if (drecasestatus != null)
            {
                DRECaseStatus = drecasestatus;
                _context.TblOptDreCaseStatuses.Remove(DRECaseStatus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
