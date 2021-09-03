using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Core.Entities
{
    public class Billetera
    {
        public long IdBilletera { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public Double Saldo { get; set; }    
    }
}
