using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class ComentarioController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /Comentario/create
        [HttpPost]
        public ActionResult Crear(ComentarioModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Comentario Comentario = new Comentario()
                {
                    ComentarioId = 106,
                    UsuarioId = 106,
                    ComentarioText = model.ComentarioText,
              
                };
                ComentarioBrl.Insertar(Comentario);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
