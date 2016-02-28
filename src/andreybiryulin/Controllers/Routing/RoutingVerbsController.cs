using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AndreyBiryulin.ViewModels;

namespace AndreyBiryulin.Controllers.Routing
{
    public class RoutingVerbsController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingVerbsController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        [AcceptVerbs("GET")]
        public IActionResult Entities() => View("RoutingInfo", routingInfo);
        [HttpPost]
        public IActionResult Entities(int id) => View("RoutingInfo", routingInfo);
    }
}
