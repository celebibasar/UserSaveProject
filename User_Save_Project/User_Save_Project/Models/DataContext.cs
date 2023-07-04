using Microsoft.EntityFrameworkCore;

namespace User_Save_Project.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Request> Requests { get; set; }
    }
}
