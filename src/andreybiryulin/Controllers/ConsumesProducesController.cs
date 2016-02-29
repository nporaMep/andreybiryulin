using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers
{
    public class ConsumesProducesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Consumes("application/json")]
        [ActionName("Consumes")]
        public IActionResult ConsumesJSON() => Content("Handled JSON at server");

        [Consumes("application/xml")]
        [ActionName("Consumes")]
        public IActionResult ConsumesXML() => Content("Handled XML at server");

        [Produces("application/xml")]
        public object ProducesXML() => new ProducesSample { prop1 = 42, prop2 = "foo" };
        [Produces("application/json")]
        public object ProducesJSON() => new ProducesSample { prop1 = 42, prop2 = "foo" };
    }

    public class ProducesSample
    {
        public int prop1 { get; set; }
        public string prop2 { get; set; }
    }
}
