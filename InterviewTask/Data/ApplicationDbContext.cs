using InterviewTask.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Unit> Units { get; set; }
        public DbSet<InvoiceDetails> invoiceDetails { get; set; }
    }
}
