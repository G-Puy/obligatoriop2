using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obli_2_p2.Controllers
{
    public class LugaresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
