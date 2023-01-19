using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Gabriel_Sebastian_CIG7.Data;
using Ungureanu_Gabriel_Sebastian_CIG7.Models;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Pages.Bilete
{
    public class DeleteModel : PageModel
    {
        private readonly Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context _context;

        public DeleteModel(Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Bilet Bilet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bilet == null)
            {
                return NotFound();
            }

            var bilet = await _context.Bilet.FirstOrDefaultAsync(m => m.ID == id);

            if (bilet == null)
            {
                return NotFound();
            }
            else 
            {
                Bilet = bilet;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Bilet == null)
            {
                return NotFound();
            }
            var bilet = await _context.Bilet.FindAsync(id);

            if (bilet != null)
            {
                Bilet = bilet;
                _context.Bilet.Remove(Bilet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
