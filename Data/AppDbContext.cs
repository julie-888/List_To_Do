using List_To_Do.Model;
using Microsoft.EntityFrameworkCore;

namespace List_To_Do.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
