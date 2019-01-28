using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class VentaController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /Venta/create
        [HttpPost]
        public ActionResult Crear(VentaModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Venta Venta = new Venta()
                {
                    VentaId = 106,
                    VideoJuegoId = 106,
                    ClienteId = 106,
                    Fecha = model.Fecha.Value,
                };
                VentaBrl.Insertar(Venta);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
