using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Route("RoutingNameWithActionToken/[action]", Name = "RoutingName[action]")]
    public class RoutingNameWithActionTokenController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingNameWithActionTokenController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index() => View("RoutingInfo", routingInfo);
        public IActionResult Other() => View("RoutingInfo", routingInfo);
    }
}
