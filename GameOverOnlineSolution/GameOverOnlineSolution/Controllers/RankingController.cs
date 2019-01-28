using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Controllers
{
    public class RankingController
    {
        public ActionResult Index()
        {
            return View();
        }
        // post /Ranking/create
        [HttpPost]
        public ActionResult Crear(RankingModel model)
        {
            Guid id = Guid.NewGuid();
            try
            {
                Ranking Ranking = new Ranking()
                {
                    RankingId = 106,
                    Puntuacion = 5,  
                };
                RankingBrl.Insertar(Ranking);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
