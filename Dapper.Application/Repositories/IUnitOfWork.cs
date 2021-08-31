using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Application.Repositories
{
    public interface  IUnitOfWork
    {
        IUsuarioRepository Usuarios { get; }
    }
}
