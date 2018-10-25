using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreUIAdmin.Controllers
{
    public class componentController : Controller
    {
        [Route("component/base/breadcrumb")]
        public IActionResult breadcrumb()
        {            
            return View();
        }

        [Route("component/base/cards")]
        public IActionResult cards()
        {
            return View();
        }

        [Route("component/base/carousel")]
        public IActionResult carousel()
        {
            return View();
        }

        [Route("component/base/collapse")]
        public IActionResult collapse()
        {
            return View();
        }

        [Route("component/base/forms")]
        public IActionResult forms()
        {
            return View();
        }

        [Route("component/base/jumbotron")]
        public IActionResult jumbotron()
        {
            return View();
        }

        [Route("component/base/list-group")]
        public IActionResult listgroup()
        {
            return View();
        }

        [Route("component/base/navs")]
        public IActionResult navs()
        {
            return View();
        }

        [Route("component/base/pagination")]
        public IActionResult pagination()
        {
            return View();
        }

        [Route("component/base/popovers")]
        public IActionResult popovers()
        {
            return View();
        }

        [Route("component/base/progress")]
        public IActionResult progress()
        {
            return View();
        }

        [Route("component/base/scrollspy")]
        public IActionResult scrollspy()
        {
            return View();
        }


        [Route("component/base/switches")]
        public IActionResult switches()
        {
            return View();
        }


        [Route("component/base/tables")]
        public IActionResult tables()
        {
            return View();
        }


        [Route("component/base/tabs")]
        public IActionResult tabs()
        {
            return View();
        }


        [Route("base/progress")]
        public IActionResult tooltips()
        {
            return View();
        }

        //Buttons

        [Route("component/buttons/buttons")]
        public IActionResult buttons()
        {
            return View();
        }

        [Route("component/buttons/button-group")]
        public IActionResult buttonsgroup()
        {
            return View();
        }

        [Route("component/buttons/dropdowns")]
        public IActionResult dropdowns()
        {
            return View();
        }

        [Route("component/buttons/brand-buttons")]
        public IActionResult bbuttons()
        {
            return View();
        }

        //Charts

        [Route("component/charts")]
        public IActionResult charts()
        {
            return View();
        }

        //Icons

        [Route("component/icons/coreui-icons")]
        public IActionResult coreuiicons()
        {
            return View();
        }

        [Route("component/icons/flags")]
        public IActionResult flags()
        {
            return View();
        }

        [Route("component/icons/font-awesome")]
        public IActionResult fontawesome()
        {
            return View();
        }

        [Route("component/icons/simple-line-icons")]
        public IActionResult simpleline()
        {
            return View();
        }


        [Route("component/notifications/alerts")]
        public IActionResult alerts()
        {
            return View();
        }

        [Route("component/notifications/badge")]
        public IActionResult badge()
        {
            return View();
        }

        [Route("component/notifications/modals")]
        public IActionResult modals()
        {
            return View();
        }

        [Route("component/widgets")]
        public IActionResult widgets()
        {
            return View();
        }





    }
}