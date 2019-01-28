using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class CompraController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /Compra/create
        [HttpPost]
        public ActionResult Crear(CompraModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Compra Compra = new Compra()
                {
                    CompraId = 106,
                    ClienteId = 106,
                    ProveedorId = 106,
                };
                CompraBrl.Insertar(Compra);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
