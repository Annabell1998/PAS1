using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repositories
{
    public class CriptomonedaRepository : ICriptomonedaRepository
    {
        public Task<int> AddAsync(Criptomoneda entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Criptomoneda>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Criptomoneda> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Criptomoneda entity)
        {
            throw new NotImplementedException();
        }
    }
}
