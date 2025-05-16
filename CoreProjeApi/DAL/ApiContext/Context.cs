using CoreProjeApi.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreProjeApi.DAL.ApiContext
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MEHMET\\SQLEXPRESS;initial catalog=PortfolyoApiDb; integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
