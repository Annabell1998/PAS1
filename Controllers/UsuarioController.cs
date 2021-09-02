using Dapper.Application.Repositories;
<<<<<<< HEAD
using Dapper.Core.Entities;
=======
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
>>>>>>> fc83d2cb26a75d1b9e2d88e1377453fe17f7430e
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

<<<<<<< HEAD
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

         
=======
        [AllowAnonymous, Route("/Usuario/googleLogin")]
        [Route("google-login")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
        //[Route("google-response")]
        //public async Task<IActionResult> GoogleResponse()
        //{

        //    var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
        //    {
        //        claim.Value
        //    });
        //    var username = claims.ToList()[1].Value;
        //    var email = claims.ToList()[4].Value;

        //    var correoBD = unitOfWork.Usuarios.GetByNameAsync(email, "PassGeneric",2);

        //    if (correoBD.Result == null)
        //    {
        //        var idResultado = await unitOfWork.Usuarios.AddAsync(email, "PassGeneric", DateTime.Now);
        //        if(idResultado != 0)
        //        {
        //            return Json(new { status = true, message = "Bienvenido " + email });
        //        }
        //        else
        //        {
        //            return Json(new { status = false, message = "Error al guardar el registro " + email });
        //        }
        //    }
        //    else
        //    {
        //        return Json(new { status = true, message = "Bienvenido " + email });
        //        //var data = await unitOfWork.Usuarios.GetByNameAsync(Email, Password);

        //    }

        //    //string resultado1 = JsonSerializer.Serialize(claims);

        //}

        //[HttpPost]
        //public async Task<IActionResult> GetUsuarios(string Email, string Password, int bandera = 1)
        //{
        //    var data = await unitOfWork.Usuarios.GetByNameAsync(Email,Password, bandera);
        //    if (data != null)
        //    {
        //        return Json(new { status = true, message = "Bienvenido " + Email });
        //    }
        //    else {
        //        return Json(new { status = false, message = "Usuario o contraseña incorrectos "});

        //    }
        //}
>>>>>>> fc83d2cb26a75d1b9e2d88e1377453fe17f7430e
    }
}
