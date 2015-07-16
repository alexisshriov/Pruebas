using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Filters;

namespace WebApplication3.Controllers
{
    public class cocinaController : Controller
    {
        [MyFilter]
        public ActionResult Search(string plato)
        {
            return Content("This is a search");
        }

    
    }
}