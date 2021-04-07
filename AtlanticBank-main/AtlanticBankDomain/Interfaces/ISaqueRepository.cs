using AtlanticBankDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Interfaces
{
    public interface ISaqueRepository : IRepository<Saque>
    { 
        Task<Saque> Update(Guid id);
    }
}
