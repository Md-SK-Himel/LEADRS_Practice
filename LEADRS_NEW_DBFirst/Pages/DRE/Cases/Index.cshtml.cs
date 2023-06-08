using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models.DRE;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Cases
{
    public class IndexModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public IndexModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        public IList<DRECase> DRECase { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DreCases != null)
            {
                DRECase = await _context.DreCases
                .Include(d => d.DREType)
                .Include(d => d.DreNotified)
                .Include(d => d.DreRequested)
                .Include(d => d.DreRole)
                .Include(d => d.Status).ToListAsync();
            }
        }
    }
}
