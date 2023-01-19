using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Gabriel_Sebastian_CIG7.Data;
using Ungureanu_Gabriel_Sebastian_CIG7.Models;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Pages.Orase
{
    public class DeleteModel : PageModel
    {
        private readonly Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context _context;

        public DeleteModel(Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Oras Oras { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Oras == null)
            {
                return NotFound();
            }

            var oras = await _context.Oras.FirstOrDefaultAsync(m => m.ID == id);

            if (oras == null)
            {
                return NotFound();
            }
            else 
            {
                Oras = oras;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Oras == null)
            {
                return NotFound();
            }
            var oras = await _context.Oras.FindAsync(id);

            if (oras != null)
            {
                Oras = oras;
                _context.Oras.Remove(Oras);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
