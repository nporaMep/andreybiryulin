using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AndreyBiryulin.ViewModels;

namespace AndreyBiryulin.Controllers
{
    public class DependencyInjectionController : Controller
    {
        private DI_A di_a;
        [FromServices]
        public DI_C DI_C { get; set; }
        [FromServices]
        public DIModelFactory DIModelFactory { get; set; }
        public DependencyInjectionController(DI_A di_a)
        {
            this.di_a = di_a;
        }
        public IActionResult Index([FromServices] DI_B di_b, [FromServices] DIModelCtor diModelCtor)
        {
            ViewData["DI_A"] = di_a;
            ViewData["DI_B"] = di_b;
            ViewData["DI_C"] = DI_C;
            ViewData["DIModel"] = DIModelFactory;
            ViewData["DIModelCtor"] = diModelCtor;
            return View();
        }
    }
}
