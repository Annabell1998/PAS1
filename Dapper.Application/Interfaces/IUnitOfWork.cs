using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Application.Interfaces
{
    public interface  IUnitOfWork
    {
        IUsuarioRepository Usuarios { get; }
        ICriptomonedaRepository Criptomoneda { get; }
    }
}
