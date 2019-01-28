using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameOverOnlineSolution.Controllers;
using Comun;
using GameOverOnlineSolution.Models;
using ClienteBrl;

namespace GameOverOnlineSolution.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /usuario/create
        [HttpPost]
        public ActionResult Crear(UsuarioModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Usuario usuario = new Usuario()
                {
                    UsuarioId = 106,
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    CorreoElectronico = model.CorreoElectronico,
                    FechaNacimiento = model.FechaNacimiento.Value,
                    Username = model.Usuario,
                    Admin = false,
                    Eliminado = false,
                };
                UsuarioBrl.Insertar(usuario);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}