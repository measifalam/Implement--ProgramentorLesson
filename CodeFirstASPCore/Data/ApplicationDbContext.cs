using CodeFirstASPCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstASPCore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
