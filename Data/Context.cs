using Microsoft.EntityFrameworkCore;
using TestApplication2.Models;

namespace TestApplication2.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}
    }
}