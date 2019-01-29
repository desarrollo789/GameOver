using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameOverOnlineSolution.Models;
using GameOverOnlineSolution.Controllers;
using GameOverOnlineSolution.Comun;


namespace GameOverOnlineSolution.Controllers
{
    public class KeyValueUsuarioListController : Controllers
    {
        //GET: /KeyValueUsuarioList/

        public ActionResult Index()
        {
            KeyValueUsuarioListModel list = KeyValueUsuarioListModel.Get();
            return View(list);
        }
    }
}