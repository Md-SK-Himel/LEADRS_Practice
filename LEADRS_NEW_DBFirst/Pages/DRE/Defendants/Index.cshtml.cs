using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Defendants
{
    public class IndexModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public IndexModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        public IList<DreDefendant> DreDefendant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DreDefendants != null)
            {
                DreDefendant = await _context.DreDefendants
                .Include(d => d.ArrestingOfficerType)
                .Include(d => d.DreCase).ToListAsync();
            }
        }
    }
}
