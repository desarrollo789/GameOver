using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class VentaDetalleController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /VentaDetalle/create
        [HttpPost]
        public ActionResult Crear(VideoJuegoModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                VentaDetalle VentaDetalle = new VentaDetalle()
                {
                    VentaDetalleId = 106,
                    VDetalle = model.VDetalle,
                };
              VentaDetalleBrl.Insertar(VentaDetalle);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
