using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Core.Entities

    /**
     * ORM de la entidad Criptomoneda
     */
{
    public class Criptomoneda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
