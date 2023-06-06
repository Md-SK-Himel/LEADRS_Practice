using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.OtherOfficers
{
    public class IndexModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public IndexModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        public IList<DreCasesOtherOfficer> DreCasesOtherOfficer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DreCasesOtherOfficers != null)
            {
                DreCasesOtherOfficer = await _context.DreCasesOtherOfficers
                .Include(d => d.DreCase)
                .Include(d => d.DreRole).ToListAsync();
            }
        }
    }
}
