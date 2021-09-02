using Dapper.Application.Repositories;
using Dapper.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration configuration;
        public UsuarioRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Usuario entity)
        {
            var sql = "INSERT INTO dbo.usuario (email, password, fecharegistro) VALUES (@Email, @Password, @Fecharegistro)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM dbo.usuario WHERE idusuario = @IdUsuario";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Usuario>> GetAllAsync()
        {
            var sql = "SELECT * FROM dbo.usuario ORDER BY idusuario";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Usuario>(sql);
                return result.ToList();
            }
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM dbo.usuario WHERE idusuario = @IdUsuario";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Usuario>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Usuario entity)
        {
            var sql = "UPDATE dbo.usuario SET email = @Email, password = @Password, fecharegistro = @Fecharegistro WHERE idusuario = @IdUsuario";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}
