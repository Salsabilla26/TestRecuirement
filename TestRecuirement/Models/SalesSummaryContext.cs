using Microsoft.EntityFrameworkCore;
namespace TestRecuirement.Models
{
    public class SalesSummaryContext : DbContext
    {
        public SalesSummaryContext(DbContextOptions<SalesSummaryContext> options) : base(options) { }

        public DbSet<SalesSummary> SalesOrders { get; set; }

    }
}
