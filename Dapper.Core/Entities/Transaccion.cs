using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Core.Entities
{
    public class Transaccion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaTransaccion { get; set; }
    }
}
