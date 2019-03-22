using MyMVCApp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class CuisineController : Controller
    {

        [Log]
        public ActionResult Search(string name = "French")
        {
            //throw new Exception("Some error message here");

            var message = Server.HtmlEncode(name);
            return Content(message);
        }

    }
}