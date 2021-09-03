using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace Dapper.Application.Interfaces
{
    // Repositorio de usuario
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByEmailAsync(string email, string passGerenic, int flag);
        Task<Usuario> GetByUsuarioAsync(string email, string password);

    }
}
