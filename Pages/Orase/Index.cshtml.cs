using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Gabriel_Sebastian_CIG7.Data;
using Ungureanu_Gabriel_Sebastian_CIG7.Models;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Pages.Orase
{
    public class IndexModel : PageModel
    {
        private readonly Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context _context;

        public IndexModel(Ungureanu_Gabriel_Sebastian_CIG7.Data.Ungureanu_Gabriel_Sebastian_CIG7Context context)
        {
            _context = context;
        }

        public IList<Oras> Oras { get;set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Companie != null)
            {
                Oras = await _context.Oras.ToListAsync();
            }
        }
    }
}
