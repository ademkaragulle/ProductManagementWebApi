using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace ProductManagementWebApi.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;initial catalog=PMWADb;integrated security=true");
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
