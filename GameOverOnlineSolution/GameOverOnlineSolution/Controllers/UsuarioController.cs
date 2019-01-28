using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameOverOnlineSolution.Controllers;
using GameOverOnlineSolution.Comun;

namespace GameOverOnlineSolution.Controllers
{
    public class UsuarioController : Controllers
    {
        public ActionResult Index()
        {
            return View();
        }
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
                    Username = model.Username,
                    Admin = false,
                    Eliminado = false,
                    Sexo = new Sexo() { SexoId = model.Sexo.SexoId },
                };
                ClienteBrl.Insertar(usuario);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}