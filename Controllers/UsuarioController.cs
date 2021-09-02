using Dapper.Application.Repositories;
using Dapper.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriptomonedasProject.Controllers
{
    public class UsuarioController : IUsuarioRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public UsuarioController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            var data = await unitOfWork.Usuarios.GetAllAsync();
            return View((IActionResult)data);
        }

        public Task<IReadOnlyList<Usuario>> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Usuario>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

         
    }
}
