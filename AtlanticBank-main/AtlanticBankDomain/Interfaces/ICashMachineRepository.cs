using AtlanticBankDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Interfaces
{
    public interface ICashMachineRepository : IRepository<CashMachine>
    {
        Task<IEnumerable<CashMachine>> GetAllCashMachines();
        Task<CashMachine> GetCashMachinesById(Guid cashMachineId);
    }
}
