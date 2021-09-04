using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repositories
{
    public class TipoOperacionRepository : ITipoOperacionRepository
    {
        public Task<int> AddAsync(TipoOperacion entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TipoOperacion>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TipoOperacion> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(TipoOperacion entity)
        {
            throw new NotImplementedException();
        }
    }
}
