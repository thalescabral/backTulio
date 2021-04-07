using AtlanticBankDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Interfaces
{
    public interface IServiceSaque
    {
        Task<CashMachineViewModel> SaqueService(SaqueViewModel saqueViewModel, Guid id);
    }
}
