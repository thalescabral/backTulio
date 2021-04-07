using AtlanticBankDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Interfaces
{
    public interface ICashMachineService : IDisposable
    {
        Task Update(CashMachine cashMachine);
    }
}
