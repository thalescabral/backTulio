using AtlanticBankData.Context;
using AtlanticBankDomain.Interfaces;
using AtlanticBankDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtlanticBankData.Repository
{
    public class CashMachineRepository : Repository<CashMachine>, ICashMachineRepository
    {
        public CashMachineRepository(ApiDbContext context) : base(context) { }

        public async Task<IEnumerable<CashMachine>> GetAllCashMachines()
        {
            return await Db.CashMachines.AsNoTracking().ToListAsync();
        }

        public async Task<CashMachine> GetCashMachinesById(Guid id)
        {
            return await Db.CashMachines.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
