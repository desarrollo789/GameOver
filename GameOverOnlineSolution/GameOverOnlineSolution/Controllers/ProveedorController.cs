using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class ProveedorController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /Proveedor/create
        [HttpPost]
        public ActionResult Crear(ProveedorModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Proveedor Proveedor = new Proveedor()
                {
                    ProveedorId = 106,
                    CorreoElectronico = model.CorreoElectronico,
                    NombreProveedor = model.NombreProveedor,
                    ApellidoProveedor = model.ApellidoProveedor,
                    Eliminado = false,
                };
                ProveedorBrl.Insertar(Proveedor);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
