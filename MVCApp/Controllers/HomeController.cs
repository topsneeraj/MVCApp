﻿using System;
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
            return View();
        }
        public void add()
        {
            int a= 10;
            int b = 30;
            int c = a + b;
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
