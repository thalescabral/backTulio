using AtlanticBankDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {   
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task<int> SaveChanges();
    }
}
