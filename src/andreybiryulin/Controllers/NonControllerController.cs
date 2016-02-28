using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers
{
    [NonController]
    public class NonControllerController : Controller
    {
        public IActionResult Index() => View();
    }
}
