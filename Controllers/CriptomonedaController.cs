using Dapper.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriptomonedasProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriptomonedaController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        // Constructor por defecto con inyección de dependencias
        public CriptomonedaController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // Listar todos
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var data = await unitOfWork.Criptomoneda.GetAllAsync();
            return Ok(data);
        }

    }
}
