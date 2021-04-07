using AtlanticBankDomain.Interfaces;
using AtlanticBankDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Services
{
    public class CashMachineService : ICashMachineService
    {
        private readonly ICashMachineRepository _cashMachineRepository;

        public CashMachineService(ICashMachineRepository cashMachineRepository)
        {
            _cashMachineRepository = cashMachineRepository;
        }

        public async Task Update(CashMachine cashMachine)
        {
            await _cashMachineRepository.Update(cashMachine);
        }

        public void Dispose()
        {
            _cashMachineRepository?.Dispose();
        }

    }
}
