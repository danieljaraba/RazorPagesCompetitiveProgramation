using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCompetitiveProgramation.Data;
using RazorPagesCompetitiveProgramation.Models;

namespace RazorPagesCompetitiveProgramation.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCompetitiveProgramation.Data.RazorPagesCompetitiveProgramationContext _context;

        public IndexModel(RazorPagesCompetitiveProgramation.Data.RazorPagesCompetitiveProgramationContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
