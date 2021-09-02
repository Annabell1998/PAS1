using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Core.Entities;

namespace Dapper.Application.Repositories
{
    public interface IUsuarioRepository: IGenericRepository<Usuario>
    {
        Task<IReadOnlyList<Usuario>> GetByEmailAsync(string email);
    }
}
