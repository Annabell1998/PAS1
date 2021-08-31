using Dapper.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        public UnitOfWork(IUsuarioRepository usuarioRepository)
        {
            Usuarios = usuarioRepository;
        }
        public IUsuarioRepository Usuarios { get; }
    }
}
