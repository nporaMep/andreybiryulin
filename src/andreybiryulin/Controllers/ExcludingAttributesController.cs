using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers
{
    public class ExcludingAttributesController : Controller
    {
        public IActionResult Index() => View();

        [NonAction]
        public int NonAction() => 42;
    }
}
