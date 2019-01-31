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
                    SexoId = new Sexo() { SexoId = usuario.Sexo. },
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int CodigoUser)
        {
            try
            {
                CargarSexo();
                Usuario user = UsuarioBrl.Get(CodigoUser);
                UsuarioModel usuario = new UsuarioModel()
                {
                    UsuarioId = usuario.UsuarioId,
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    CorreoElectronico = usuario.CorreoElectronico,
                    FechaNacimiento = usuario.FechaNacimiento,
                    Fechaderegistro = usuario.Fechaderegistro,
                    Username = model.Username,
                    SexoId = new Sexo() { SexoId = usuario.Sexo.Nombre  },
                    Administrador = false,
                    Eliminado = false,
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
