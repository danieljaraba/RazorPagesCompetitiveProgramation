using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCompetitiveProgramation.Models;

namespace RazorPagesCompetitiveProgramation.Data
{
    public class RazorPagesCompetitiveProgramationContext : DbContext
    {
        public RazorPagesCompetitiveProgramationContext (DbContextOptions<RazorPagesCompetitiveProgramationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCompetitiveProgramation.Models.User> User { get; set; }
    }
}
