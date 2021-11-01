using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMC.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PreguntasAmc()
        {
            return View();
        }

        public ActionResult PreguntasFa()
        {
            return View();
        }

        public ActionResult PreguntasMc()
        {
            return View();
        }

        public ActionResult PreguntasEg()
        {
            return View();
        }

        public ActionResult PreguntasEE()
        {
            return View();
        }

        public ActionResult PreguntasStrib()
        {
            return View();
        }

        public ActionResult Penalidad()
        {
            return View();
        }
    }
}