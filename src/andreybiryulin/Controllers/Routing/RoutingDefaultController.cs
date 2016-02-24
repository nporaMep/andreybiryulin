using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    public class RoutingDefaultController : Controller
    {
        private readonly RoutingInfo routingInfo;

        public RoutingDefaultController(RoutingInfo routingInfo) {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index() => View();
        public IActionResult Other() => View("RoutingInfo", routingInfo);
        public IActionResult OptionalParam(int id) => View("RoutingInfo", routingInfo);
        public IActionResult OptionalMultipleParams(int id, int anotherId) => View("RoutingInfo", routingInfo);
    }
}
