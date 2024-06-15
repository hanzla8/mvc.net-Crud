using BestSroreMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BestSroreMvc.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products {  get; set; }
    }
}
