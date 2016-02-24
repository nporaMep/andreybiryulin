using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Area("Area2")]
    [Route("RenamedArea/[action]", Name ="RenamedArea_[action]")]
    public class RoutingAreaRenamedController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingAreaRenamedController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index() => View("RoutingInfo", routingInfo);
    }
}
