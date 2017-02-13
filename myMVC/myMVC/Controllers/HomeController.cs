using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string id,string name)
        {
            return "Id=" + id+" Name="+name;
        }

        public ViewResult GetCountries()
        {
            ViewBag.Countries=new List<string>() {
            "India",
            "US",
            "UK",
            "Germany"
            };

            return View();
        }
        public ViewResult GetCountrieViewData()
        {
            ViewData["Countries"] = new List<string>() {
            "India",
            "US",
            "UK",
            "Germany",
            "Spain"
            };

            return View();
        }


        public String GetMvcVersion()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public string GetMethod()
        {
            return "Getmethod Invoked";
        }

    }
}
