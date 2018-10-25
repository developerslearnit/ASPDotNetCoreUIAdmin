using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreUIAdmin.Controllers
{
    public class colorsController : Controller
    {
        [Route("theme/colors")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("theme/typography")]
        public IActionResult typo()
        {
            return View();
        }
    }
}