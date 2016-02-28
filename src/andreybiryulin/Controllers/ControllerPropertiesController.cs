using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AndreyBiryulin.ViewModels;

namespace AndreyBiryulin.Controllers
{
    public class ControllerPropertiesController : Controller
    {
        [FromServices]
        public RoutingInfo RoutingInfo { get; set; }
        public IActionResult Index() => View();
        [HttpGet]
        [Route("/[action]/{id}", Name = "ActionContextRoute", Order = int.MinValue)]
        public IActionResult GetActionContext(int id) => View(ActionContext);
        public IActionResult GetBindingContext() => View(BindingContext);
        public IActionResult GetHttpContext() => View(HttpContext);
        public IActionResult GetMetadataProvider() => View(MetadataProvider);
        public IActionResult GetModelState() => View(ModelState);
        public IActionResult GetObjectValidator() => View(ObjectValidator);
        public IActionResult GetHttpRequest() => View(Request);
        public IActionResult GetResolver() => View(Resolver);
        public IActionResult GetHttpResponse() => View(Response);
        public IActionResult GetRouteData() => View(RouteData);
        public IActionResult GetTempData() => View(TempData);
        public IActionResult GetUrl() => View(Url);
        public IActionResult GetUser() => View(User);

        public IActionResult GetViewBag()
        {
            ViewBag.CustomProperty = "CustomPropertyValue";
            return View(ViewBag);
        }
        public IActionResult GetViewData()
        {
            ViewData["DataInAdditonToModel"] = "some data";
            return View(RoutingInfo);
        }
    }
}
