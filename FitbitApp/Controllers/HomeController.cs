using FitbitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FitbitApp.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
           
        }

        public ActionResult Index(CredModel model)
        {
            if(model == null)
            {
                return View();
            }

            return View("downloadfile", model);
        }
    }
}
