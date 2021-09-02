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
        public UnitOfWork(
            IUsuarioRepository usuarioRepository,
            ICriptomonedaRepository criptomonedaRepository
            )
        {
            Usuarios = usuarioRepository;
            Criptomoneda = criptomonedaRepository;
        }
        public IUsuarioRepository Usuarios { get; }

        public ICriptomonedaRepository Criptomoneda { get; }
    }
}
