using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Numerics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Main> Mains { get; set; }
        public DbSet<Depend> Depends { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
