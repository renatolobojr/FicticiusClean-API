using Logistics.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Logistics.SQLite
{
    public class LogisticsContext : DbContext
    {
        //public LogisticsContext(DbContextOptions<LogisticsContext> options) : base(options)
        //{
        //    ;
        //}
        public DbSet<Vehicle>? Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vehicle>().HasKey(v => v.Guid);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource = Dados/Logistics.db ; cache=shared");
        }

    }
}