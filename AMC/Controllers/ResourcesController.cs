using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMC.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mantenimiento()
        {
            return View();
        }

        public ActionResult ProxGanadores()
        {
            return View();
        }

        public ActionResult YaParticipaste()
        {
            return View();
        }

        public ActionResult FinalJuego()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Explicacion()
        {
            return View();
        }
    }
}