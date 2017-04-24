using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnookerAcadWebApp.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: Article/List
        public ActionResult List()
        {
            return View();
        }
    }
}