using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndreyBiryulin.ViewComponents
{
    public class ReturnType : ViewComponent
    {
        public IViewComponentResult Invoke(int val) => Json(new { message = "This is ReturnType ViewComponent", passedValue = val });
    }
}
