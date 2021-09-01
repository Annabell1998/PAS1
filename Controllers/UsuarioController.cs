using Dapper.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriptomonedasProject.Controllers
{
    public class UsuarioController : Controller
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
    }
}
