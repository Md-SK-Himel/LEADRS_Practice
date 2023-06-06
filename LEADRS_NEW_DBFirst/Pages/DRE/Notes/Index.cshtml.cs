using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.Notes
{
    public class IndexModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public IndexModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        public IList<DreCaseNote> DreCaseNote { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DreCaseNotes != null)
            {
                DreCaseNote = await _context.DreCaseNotes
                .Include(d => d.DreCase)
                .Include(d => d.DreCaseNoteType).ToListAsync();
            }
        }
    }
}
