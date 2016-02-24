using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Route("RoutingPrefixHeader/[action]")]
    public class RoutingPrefixHeaderController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingPrefixHeaderController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }

        public IActionResult Index() => View("RoutingInfo", routingInfo);
        [Route("{id}")]
        public IActionResult PrefixedMandatoryParam(int id) => View("RoutingInfo", routingInfo);
        [Route("/AnotherRoute/RenamedActionWithHeaderAttribute")]
        public IActionResult RenamedAction() => View("RoutingInfo", routingInfo);
        [Route("{val}/child/{subval}")]
        public IActionResult ExtendedAction(int val, string subval) => View("RoutingInfo", routingInfo);
    }
}
