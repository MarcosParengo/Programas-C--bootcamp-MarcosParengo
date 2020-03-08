using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using empezamos_con_web.Models;

namespace empezamos_con_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();  
            int r = random.Next();

            String mensajito = "";
            if (r % 2 == 0)
            {
                mensajito = "Jesucristo es mi señor.";
            }

            ViewData["mensaje"] = mensajito;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
