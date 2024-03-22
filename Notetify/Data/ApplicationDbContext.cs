using Microsoft.EntityFrameworkCore;
using Notetify.Models;

namespace Notetify.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
    }
}
