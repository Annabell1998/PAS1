using Dapper.Application.Interfaces;
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
            ICriptomonedaRepository criptomonedaRepository,
            IBilleteraRepository billeteraRepository,
            ITipoOperacionRepository tipoOperacionRepository,
            ITransaccionRepository transaccionRepository
            )
        {
            Usuarios = usuarioRepository;
            Criptomoneda = criptomonedaRepository;
            Billetera = billeteraRepository;
            TipoOperacion = tipoOperacionRepository;
            Transaccion = transaccionRepository;
            
        }
        public IUsuarioRepository Usuarios { get; }

        public ICriptomonedaRepository Criptomoneda { get; }

        public IBilleteraRepository Billetera { get; }

        public ITipoOperacionRepository TipoOperacion { get; }

        public ITransaccionRepository Transaccion { get;}
    }
}
