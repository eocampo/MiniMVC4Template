using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniMVC4Template.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index() {
            return "<html><head><title>MiniMVC4Template</title></head><body><h1>MiniMVC4Template</h1></body></html>";
        }

    }
}
