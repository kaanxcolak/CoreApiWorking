using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            //ctora parametre verdik. Generic parametre Böylece connection string özelliğini OPSİYON olarak Program.cs üzerinden ayarlayacağız.

        }
        public DbSet<Student>  StudentTable { get; set; }
        public DbSet<Deneme1>  Deneme1 { get; set; }
        public DbSet<Deneme2>  Deneme2 { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Deneme2>(b =>
            {
                b.ToTable("Deneme2Table");
                b.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(20,3);
            });
        }
    }
}
