using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Application.Repositories;
using Dapper.Core.Entities;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace Dapper.Application.Repositories
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {

    }
}
