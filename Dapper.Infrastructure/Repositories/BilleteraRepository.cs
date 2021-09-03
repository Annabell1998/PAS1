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
    public class BilleteraRepository : IBilleteraRepository
    {
        private readonly IConfiguration configuration;

        public BilleteraRepository(
                IConfiguration configuration
            )
        {
            this.configuration = configuration;
        }
        public async Task<int> AddAsync(Billetera entity)
        {
            var sql = "INSERT INTO dbo.billetera (idUsuario, nombre, saldo) VALUES (@IdUsuario, @Nombre, @Saldo)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM dbo.billetera WHERE idbilletera = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id});
                return result;
            }
        }

        public async Task<IReadOnlyList<Billetera>> GetAllAsync()
        {
            var sql = "SELECT * FROM dbo.billetera ORDER BY idbilletera";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Billetera>(sql);
                return result.ToList();
            }
        }

        public async Task<Billetera> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM dbo.billetera WHERE idbilletera = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Billetera>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Billetera entity)
        {
            var sql = "UPDATE dbo.billetera" +
                "         SET nombre = @Nombre" +
                "       WHERE idbilletera = @Id"
                ;
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}
