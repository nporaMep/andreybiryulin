using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Area("Area1")]
    [Route("[area]/[controller]/[action]", Name ="[area]_[action]")]
    public class RoutingAreaDefaultController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingAreaDefaultController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index() => View("RoutingInfo", routingInfo);
    }
}
