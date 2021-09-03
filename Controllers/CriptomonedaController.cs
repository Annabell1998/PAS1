using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
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

        // Obtiene registro por ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.Criptomoneda.GetByIdAsync(id);
            if (data == null) return Ok("No se encontró este registro");
            return Ok(data);
        }

        // Inserta registro
        [HttpPost]
        public async Task<IActionResult> Add(Criptomoneda criptomoneda)
        {
            var data = await unitOfWork.Criptomoneda.AddAsync(criptomoneda);
            return Ok(data);
        }

        // Actualiza registro
        [HttpPut]
        public async Task<IActionResult> Update(Criptomoneda criptomoneda)
        {
            var data = await unitOfWork.Criptomoneda.UpdateAsync(criptomoneda);
            return Ok(data);
        }



    }

}
