using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    [Route("RoutingMandatoryControllerParam/[action]/{id}")]
    public class RoutingMandatoryControllerParamController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingMandatoryControllerParamController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index(int id) => View("RoutingInfo", routingInfo);
        public IActionResult Other(int id) => View("RoutingInfo", routingInfo);
        [Route("/[controller]/[action]")]
        public IActionResult RemovedMandatoryParam() => View("RoutingInfo", routingInfo);
    }
}
