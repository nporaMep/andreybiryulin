using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Mvc;

namespace AndreyBiryulin.Controllers.Routing
{
    public class RoutingActionController : Controller
    {
        private RoutingInfo routingInfo;

        public RoutingActionController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        [Route("[controller]")]
        public IActionResult NotDefaultIndex() => View("RoutingInfo", routingInfo);
        [Route("AnotherPath/AnotherAction")]
        public IActionResult ReroutedToAnotherPath() => View("RoutingInfo", routingInfo);
        [Route("[controller]/Path1")]
        [Route("[controller]/Path2")]
        public IActionResult MultiplePaths() => View("RoutingInfo", routingInfo);
        [Route("[controller]/[action]/{mandatoryParam}")]
        public IActionResult MandatoryParam(string mandatoryParam) => View("RoutingInfo", routingInfo);
        [Route("[controller]/[action]/{*greedyParam}")]
        public IActionResult GreedyParam(string greedyParam) => View("RoutingInfo", routingInfo);
        [Route("[controller]/[action]/{parentId}/ChildEntity1/{childId}")]
        public IActionResult NestedParameters(int parentId, int childId) => View("RoutingInfo", routingInfo);
    }
}
