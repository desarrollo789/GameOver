using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class VideoJuegoController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /VideoJuego/create
        [HttpPost]
        public ActionResult Crear(VideoJuegoModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                VideoJuego VideoJuego = new VideoJuego()
                {
                    VideoJuegoId = 106,
                    Nombre = model.Nombre,
                    Precio = 200 ,
                    Portada = model.Portada,
                    Trailer = model.trailer,
                    Eliminado = false,
                };
                VideoJuegoBrl.Insertar(VideoJuego);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}