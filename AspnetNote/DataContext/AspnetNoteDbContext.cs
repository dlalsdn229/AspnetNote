using AspnetNote.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetNote.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;Encrypt=false;User Id=sa;Password=sa1234;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
