using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proekt.Data;
using proekt.Model;

namespace proekt.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly proekt.Data.proektContext _context;

        public IndexModel(proekt.Data.proektContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
