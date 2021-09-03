using Dapper.Application.Interfaces;
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
    public class CriptomonedaRepository : ICriptomonedaRepository
    {
        private readonly IConfiguration configuration;

        public CriptomonedaRepository(
                IConfiguration configuration
            )
        {
            this.configuration = configuration;
        }

        // Agrega un registro
        public async Task<int> AddAsync(Criptomoneda entity)
        {
            var sql = "INSERT INTO dbo.criptomoneda (idcriptomoneda, nombre, precio) VALUES (@Id, @Nombre, @Precio)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }

        }

        // Elimina un registro por ID
        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM dbo.criptomoneda WHERE idcriptomoneda = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        // Obtiene todos los registros
        public async Task<IReadOnlyList<Criptomoneda>> GetAllAsync()
        {
            var sql = "SELECT * FROM dbo.criptomoneda ORDER BY idcriptomoneda";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Criptomoneda>(sql);
                return result.ToList();
            }

        }

        // Obtiene registro por ID
        public async Task<Criptomoneda> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM dbo.criptomoneda WHERE idcriptomoneda = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Criptomoneda>(sql, new { Id = id });
                return result;
            }
        }

        // Actualiza los campos del registro
        public async Task<int> UpdateAsync(Criptomoneda entity)
        {
            var sql = "UPDATE dbo.criptomoneda" +
                "         SET nombre = @Nombre," +
                "             precio = @Precio" +
                "       WHERE idcriptomoneda = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}
