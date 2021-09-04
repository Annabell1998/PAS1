
using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Application.Interfaces
{
    /**
     * Esta interfaz genérica contendrá todos los métodos básicos para ejecutarse en una base de datos.
     * 
     * Dicha interfaz será heredada en los demás repositorios futuros
     */
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);

    }
}
