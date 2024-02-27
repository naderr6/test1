using Aulfah.Models;
using Microsoft.EntityFrameworkCore;
using Aulfah.DAL.Model;

namespace Aulfah.DataContex
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {


        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Tracking> Track { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}



