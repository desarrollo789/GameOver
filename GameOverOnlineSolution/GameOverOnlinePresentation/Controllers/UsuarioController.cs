using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comun;
using ClienteBrl;
using GameOverOnlinePresentation.Models;

namespace GameOverOnlinePresentation.Controllers
{
    public class UsuarioController : Controller
    {

        /// <summary>
        /// Controlador para el Usuario
        /// </summary>
        /// <

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            CargarSexo();
            UsuarioModel usuario = new UsuarioModel();
            return View(usuario);
        }

        public void CargarSexo()
        {
            ViewBag.ListaSexos = new SelectList(
            (
                from t in SexoListController.SexoModel
                select new SelectListItem
                {
                    Text = t.NombreSexo,
                    Value = t.SexoId.ToString()
                }
            )
            , "Value", "Text");
        }
        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(UsuarioModel model)
        {
            CargarSexo();
            Guid id = Guid.NewGuid();
            try
            {
                // TODO: Add insert logic here
                Usuario usuario = new Usuario()
                {
                    UsuarioId = 106,
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    CorreoElectronico = model.CorreoElectronico,
                    FechaNacimiento = model.FechaNacimiento.Value,
                    Fechaderegistro = model.Fechaderegistro.Value,
                    Username = model.Username,
                    SexoId = new Sexo() { SexoId = model.Sexo.SexoId},
                    Administrador = false,
                    Eliminado = false,
                };
                UsuarioBrl.Insertar(usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        




        // GET: Usuario/Edit/5
        public ActionResult Edit(int CodigoUser)
        {
            CargarSexo();
            Usuario user = UsuarioBrl.Get(CodigoUser);
            UsuarioModel usuario = new UsuarioModel()
            {
                UsuarioId = user.UsuarioId,
                Nombre = user.Nombre,
                Apellido = user.Apellido,
                CorreoElectronico = user.CorreoElectronico,
                FechaNacimiento = user.FechaNacimiento,
                Fechaderegistro = user.Fechaderegistro,
                Username = user.Username,
                Eliminado = user.Eliminado,
                SexoId = new SexoModel() { SexoId = user.SexoId.SexoId , Nombre = user.SexoId.Nombre},
                
            };
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int CodigoUser, UsuarioModel model)
        {
            CargarSexo();
            try
            {
                Usuario usuario = new Usuario()
                {
                    UsuarioId = CodigoUser,
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    Username = model.Username,
                    Eliminado = false,
                    FechaNacimiento = model.FechaNacimiento.Value,
                    SexoId = new Sexo() { SexoId = model.SexoId.SexoId },
                };
                UsuarioBrl.Actualizar(usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int CodigoUser)
        {
            try
            {
                // TODO: Add delete logic here

                UsuarioBrl.Eliminar(CodigoUser);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
