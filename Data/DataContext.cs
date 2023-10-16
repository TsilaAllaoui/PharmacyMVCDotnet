using Microsoft.EntityFrameworkCore;
using PharmacyMVC.Models;

namespace PharmacyMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        { 
        
        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
