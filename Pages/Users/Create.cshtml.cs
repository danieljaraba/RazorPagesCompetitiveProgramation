using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCompetitiveProgramation.Data;
using RazorPagesCompetitiveProgramation.Models;

namespace RazorPagesCompetitiveProgramation.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCompetitiveProgramation.Data.RazorPagesCompetitiveProgramationContext _context;

        public CreateModel(RazorPagesCompetitiveProgramation.Data.RazorPagesCompetitiveProgramationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
