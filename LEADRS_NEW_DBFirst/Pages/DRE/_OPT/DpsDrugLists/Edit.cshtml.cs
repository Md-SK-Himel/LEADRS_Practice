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

namespace LEADRS_NEW_DBFirst.Pages.DRE._OPT.DpsDrugLists
{
    public class EditModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public EditModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblOptDpsDrugList TblOptDpsDrugList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TblOptDpsDrugLists == null)
            {
                return NotFound();
            }

            var tbloptdpsdruglist =  await _context.TblOptDpsDrugLists.FirstOrDefaultAsync(m => m.DpsDrugListId == id);
            if (tbloptdpsdruglist == null)
            {
                return NotFound();
            }
            TblOptDpsDrugList = tbloptdpsdruglist;
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

            _context.Attach(TblOptDpsDrugList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblOptDpsDrugListExists(TblOptDpsDrugList.DpsDrugListId))
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

        private bool TblOptDpsDrugListExists(int id)
        {
          return (_context.TblOptDpsDrugLists?.Any(e => e.DpsDrugListId == id)).GetValueOrDefault();
        }
    }
}
