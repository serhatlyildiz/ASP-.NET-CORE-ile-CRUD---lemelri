using Microsoft.EntityFrameworkCore;

namespace Proje1.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E987DJB\\SQLEXPRESS; Database=NETCORE; Trusted_Connection=True;");
        }

        public DbSet<departmanlar> _GorevDepartmans { get; set; }

        public DbSet<personel> _Personels { get; set; } 

        //public DbSet<Admin> Admin { get; set; }
    }
}
