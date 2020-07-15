using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    // GET http://localhost:3000/Homeindex
    //home controller
   //index --- action method
    public class HomeController : Controller
    {
        //Action method
        public IActionResult Index()
        {
            //return an instance of a class that implements that interface
            return View();
        }
    }
}
