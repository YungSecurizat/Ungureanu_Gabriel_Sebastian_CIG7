using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ungureanu_Gabriel_Sebastian_CIG7.Data;
using Ungureanu_Gabriel_Sebastian_CIG7.Models;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Pages.Orase
{
    public class CreateModel : PageModel
    {
        private readonly Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context _context;

        public CreateModel(Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Oras Oras { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Oras.Add(Oras);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
