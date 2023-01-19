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
    public class DetailsModel : PageModel
    {
        private readonly Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context _context;

        public DetailsModel(Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context context)
        {
            _context = context;
        }

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
    }
}
