using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AndreyBiryulin.ViewModels;
using Microsoft.AspNet.Http;

namespace AndreyBiryulin.Controllers
{
    public class ModelBindingController : Controller
    {
        private RoutingInfo routingInfo;

        public ModelBindingController(RoutingInfo routingInfo)
        {
            this.routingInfo = routingInfo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FromQuery([FromQuery] int FromQuery) => View("RoutingInfo", routingInfo);

        public IActionResult FromRoute([FromRoute(Name ="id")] int FromRoute) => View("RoutingInfo", routingInfo);

        public string FromBody([FromBody] int fromBody)
        {
            return $"Message from server {fromBody}";
        }

        public IActionResult FromForm(IFormCollection formData, [FromForm] string text1, [FromForm] int number1, [FromForm] string text2)
        {
            ViewBag.FormData = formData;
            ViewBag.text1 = text1;
            ViewBag.number1 = number1;
            ViewBag.text2 = text2;
            return View();
        }

        public IActionResult FormFile(IFormFile formFile) => View(formFile);
    }
}
