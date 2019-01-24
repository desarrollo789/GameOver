using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaNro1Solution.Models;

namespace PracticaNro1Solution.Controllers
{
    public class PracticaNro1Controller : Controller
    {
        // GET: PracticaNro1
        //Get: Ejercicio nro 1
        public ActionResult Ejecicio1()
        {
            EjercicioNro1 ejercicio1 = new EjercicioNro1();
            return View();
        }

        [HttpPost]
        public ActionResult Ejecicio1(EjercicioNro1 model)
        {
            model.respuesta = (int)Math.Pow(model.numero_a, model.numero_b);
            return View(model);
        }
        // 
    }
}