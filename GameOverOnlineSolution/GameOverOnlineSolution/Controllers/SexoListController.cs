using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOverOnlineSolution.Controllers
{
    public class SexoListController : Controllers
    {
        private static List<SexoModel> _sexoModel;

        public static List<SexoModel> SexoModel
        {
            get
            {
                _sexoModel = new List<SexoModel>();
                foreach (var sexo in SexoListBrl.Get())
                {
                    _sexoModel.Add(new SexoModel
                    {
                        SexoId = sexo.SexoId,
                        Nombre = sexo.Nombre,
                    });
                }
                return _sexoModel;
            }
            set { _sexoModel = value; }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}