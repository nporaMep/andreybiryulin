using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Route("RenamedRoute/[action]")]
    public class RoutingRenamingHeaderController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingRenamingHeaderController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index() => View("RoutingInfo", routingInfo);
        public IActionResult Other() => View("RoutingInfo", routingInfo);
    }
}
