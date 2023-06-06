using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LEADRS_NEW_DBFirst.Data;
using LEADRS_NEW_DBFirst.Models;

namespace LEADRS_NEW_DBFirst.Pages.DRE.DarkRooms
{
    public class DeleteModel : PageModel
    {
        private readonly LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext _context;

        public DeleteModel(LEADRS_NEW_DBFirst.Data.LeadrsCoreDevNewContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DreCasesDarkRoom DreCasesDarkRoom { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DreCasesDarkRooms == null)
            {
                return NotFound();
            }

            var drecasesdarkroom = await _context.DreCasesDarkRooms.FirstOrDefaultAsync(m => m.DreCaseDarkRoomId == id);

            if (drecasesdarkroom == null)
            {
                return NotFound();
            }
            else 
            {
                DreCasesDarkRoom = drecasesdarkroom;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DreCasesDarkRooms == null)
            {
                return NotFound();
            }
            var drecasesdarkroom = await _context.DreCasesDarkRooms.FindAsync(id);

            if (drecasesdarkroom != null)
            {
                DreCasesDarkRoom = drecasesdarkroom;
                _context.DreCasesDarkRooms.Remove(DreCasesDarkRoom);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
