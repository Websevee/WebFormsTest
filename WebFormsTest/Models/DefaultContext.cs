using System.Data.Entity;

namespace WebFormsTest.Models
{
    public class DefaultContext : DbContext
    {
        public DefaultContext()
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}