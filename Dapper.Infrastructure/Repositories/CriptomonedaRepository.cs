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
    /**
     * Implementación del repositorio para la entidad Criptomoneda
     * 
     */
    public class CriptomonedaRepository : ICriptomonedaRepository
    {
        private readonly IConfiguration configuration;

        // Constructor de la clase
        public CriptomonedaRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // Agrega un nuevo registro
        public async Task<int> AddAsync(Criptomoneda entity)
        {
            // Sentencia SQL
            var sql = "INSERT INTO dbo.criptomoneda (idcriptomoneda, nombrecriptomoneda) " +
                "       VALUES (@Id, @Nombre)";
            // Obtiene la conexión por defecto
            using(var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                // Abre la conexión
                connection.Open();
                // Ejecuta la sentencia
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        // Elimina un registro por medio de Id
        public async Task<int> DeleteAsync(int id)
        {
            // Sentencia SQL
            var sql = "DELETE FROM dbo.criptomoneda WHERE idcriptomoneda = @Id";
            // Obtiene la conexión por defecto
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                // Abre la conexión
                connection.Open();
                // Ejecuta la sentencia
                var result = await connection.ExecuteAsync(sql, id);
                return result;
            }

        }

        // Obtiene todos los registros de la entidad
        public async Task<IReadOnlyList<Criptomoneda>> GetAllAsync()
        {
            var sql = "SELECT * FROM dbo.criptomoneda ORDER BY idcriptomoneda";
            // Obtiene la conexión por defecto
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                // Abre la conexión
                connection.Open();
                // Ejecuta la sentencia
                var result = await connection.QueryAsync<Criptomoneda>(sql);
                return result.ToList();
            }

        }

        // Obtiene un registro por medio de ID
        public async Task<Criptomoneda> GetByIdAsync(int id)
        {
            // Sentencia SQL
            var sql = "SELECT * FROM dbo.criptomoneda WHERE idcriptomoneda = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                // Abre la conexión
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Criptomoneda>(sql, new { IdUsuario = id });
                return result;
            }
        }

        // Actualiza un registro existente
        public async Task<int> UpdateAsync(Criptomoneda entity)
        {
            var sql = "UPDATE dbo.criptomoneda" +
                "         SET nombrecriptomoneda = @Nombre" +
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
