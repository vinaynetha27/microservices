using microservices.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace microservices.Data
{
    public class ModeldbContext : DbContext
    {
        public ModeldbContext(DbContextOptions<ModeldbContext> options): base(options) {
        }

        public DbSet<Products> Products { get; set; }
    }
}
