using AtlanticBankDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace AtlanticBankData.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CashMachine> CashMachines { get; set; }
        public DbSet<Saque> Saques { get; set; }

    }
}
