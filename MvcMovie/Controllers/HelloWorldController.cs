﻿using System.Web;
using System.Web.Mvc;

//namespace MvcMovie.Controllers
//{
//    public class HelloWorldController : Controller
//    {
//        // 
//        // GET: /HelloWorld/ 

//        //public string Index()
//        //{
//        //    return "This is my <b>default</b> action...";
//        //}

//        // 
//        // GET: /HelloWorld/Welcome/ 

//        //public string Welcome()
//        //{
//        //    return "This is the Welcome action method...";
//        //}

//        public ActionResult Index()
//        {
//            return View();
//        }

//        public string Welcome(string name, int numTimes = 1)
//        {
//            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
//        }
//    }
//}

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}