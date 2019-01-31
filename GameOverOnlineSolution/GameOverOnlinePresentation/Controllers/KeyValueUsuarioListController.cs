using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameOverOnlinePresentation.Models;

namespace GameOverOnlinePresentation.Controllers
{
    public class KeyValueUsuarioListController : Controller
    {
        //GET: KeyValueUsuarioList/

        public ActionResult Index()
        {
            KeyValueUsuarioListModel list = KeyValueUsuarioListModel.Get();
            return View(list);
        }
    }
}