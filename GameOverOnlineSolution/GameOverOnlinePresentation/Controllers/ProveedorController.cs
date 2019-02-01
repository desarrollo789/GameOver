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
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proveedor/Create
        public ActionResult Create()
        {
            ProveedorModel proveedor = new ProveedorModel();
            return View(proveedor);
        }

        // POST: Proveedor/Create
        [HttpPost]
        public ActionResult Create(ProveedorModel model)
        {
            try
            {
                // TODO: Add insert logic here
                Guid id = Guid.NewGuid();
                Proveedor proveedor = new Proveedor()
                {
                    ProveedorId = 106,
                    NombreProveedor = model.NombreProveedor,
                    ApellidoProveedor= model.ApellidoProveedor,
                    CorreoElectronico = model.ApellidoProveedor,
                    Eliminado= false,
                };
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int id)
        {
            Proveedor proveedor = ProveedorBrl.get(id);
            ProveedorModel proveedor = new ProveedorModel()
            {
                ProveedorId = proveedor.ProveedorId,
                NombreProveedor = proveedor.NombreProveedor,
                ApellidoProveedor = proveedor.ApellidoProveedor,
                CorreoElectronico = Proveedor.ApellidoProveedor,
                Eliminado = false,
            };
            return View();
        }

        // POST: Proveedor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,ProveedorModel model)
        {
            try
            {
                // TODO: Add update logic here
                ProveedorModel proveedor = new ProveedorModel()
                {
                    ProveedorId = id,
                    NombreProveedor=model.NombreProveedor,
                    ApellidoProveedor = model.ApellidoProveedor,
                    CorreoElectronico=model.CorreoElectronico,
                    Eliminado = false,
                };
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proveedor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                ProveedorBrl.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
