using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE.LU;

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DpsDrugLists
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DpsDrugList DpsDrugList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDpsDrugLists == null)
            {
                return NotFound();
            }

            var dpsdruglist = await _context.TblOptDpsDrugLists.FirstOrDefaultAsync(m => m.DpsDrugListId == id);

            if (dpsdruglist == null)
            {
                return NotFound();
            }
            else 
            {
                DpsDrugList = dpsdruglist;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TblOptDpsDrugLists == null)
            {
                return NotFound();
            }
            var dpsdruglist = await _context.TblOptDpsDrugLists.FindAsync(id);

            if (dpsdruglist != null)
            {
                DpsDrugList = dpsdruglist;
                _context.TblOptDpsDrugLists.Remove(DpsDrugList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
