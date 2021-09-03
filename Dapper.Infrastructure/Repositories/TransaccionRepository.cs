using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repositories
{
    public class TransaccionRepository : ITransaccionRepository
    {
        public Task<int> AddAsync(Transaccion entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Transaccion>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Transaccion> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Transaccion entity)
        {
            throw new NotImplementedException();
        }
    }
}
