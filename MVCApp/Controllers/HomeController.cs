using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          /// code is edited is testying 
          /// this is agian new code added
          /// added new test controller 
          // added featus 2
          /// added features 3
         
            return View();
        }
        public int  add(int a ,int b)
        {
            int c = 30+50;
           return a + b;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
