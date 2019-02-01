using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Comun;
using ClienteBrl;
using GameOverOnlinePresentation.Models;

namespace GameOverOnlinePresentation.Controllers
{
    public class VideoJuegoController : Controller
    {
        //
        // GET: /VideoJuego/

        public ActionResult Index()
        {
            return View();
        }

        //
        //GET: /VideoJuego/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        //GET: /VideoJuego/Create

        public ActionResult Crear()
        {
            VideoJuegoModel videoJuego = new VideoJuegoModel();
            return View(videoJuego);
        }
        //
        //POST: /VideoJuego/Create

        [HttpPost]
        public ActionRestult Create(VideoJuegoModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                //TODO: Add insert logic here
                VideoJuego videoJuego = new VideoJuego()
                {
                    VideoJuegoId = 106,
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    Precio = model.Precio,
                    Portada = model.Portada,
                    Trailer = model.Trailer,
                    Eliminado = false,
                    Fecha = model.Fecha.Value,
                    Ranking = new Ranking() { RankingId = model.Ranking.RankingId },
                    Categoria = new Categoria() { CategoriaId = model.Categoria.CategoriaId },
                    Comentario = new Comentario() { ComentarioId = model.Comentario.ComentarioId },
                    Proveedor = new Proveedor() { ProveedorId = model.Proveedor.ProveedorId }
                };
                videoJuegoBrl.Insertar(videoJuego);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}