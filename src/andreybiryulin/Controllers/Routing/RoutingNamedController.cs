using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Route("RoutingNamed", Name ="NamedController1")]
    public class RoutingNamedController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingNamedController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        [HttpGet]
        public IActionResult Get() => View("RoutingInfo", routingInfo);
        [HttpPost]
        public IActionResult Post() => View("RoutingInfo", routingInfo);
        [Route("[action]", Name = "NamedAction1")]
        public IActionResult NamedAction() => View("RoutingInfo", routingInfo);
    }
}
