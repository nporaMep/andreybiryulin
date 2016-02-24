using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Controllers;
using Microsoft.AspNet.Mvc.Infrastructure;
using Microsoft.AspNet.Mvc.ModelBinding;
using Microsoft.AspNet.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndreyBiryulin.ViewModels
{
    public class RoutingInfo
    {
        private IActionContextAccessor contextAccessor;
        private IUrlHelper urlHelper;
        private ActionContext actionContext => contextAccessor.ActionContext;

        public RoutingInfo(IActionContextAccessor contextAccessor, IUrlHelper urlHelper)
        {
            this.contextAccessor = contextAccessor;
            this.urlHelper = urlHelper;
        }
        public string DefaultURL { get; set; } = string.Empty;
        public string DisplayName => contextAccessor.ActionContext.ActionDescriptor.DisplayName;
        public string RequestedUrl => string.Empty;
        public string ActualURL => actionContext.HttpContext.Request.Path.Value;
        public string Controller => ((ControllerActionDescriptor)actionContext.ActionDescriptor).ControllerName;
        public string Action => actionContext.ActionDescriptor.Name;
        public Dictionary<string, object> RouteValues => new Dictionary<string, object>(actionContext.RouteData.Values);
        public IList<RouteDataActionConstraint> Constraints => actionContext.ActionDescriptor.RouteConstraints;
        public ModelStateDictionary ModelState => actionContext.ModelState;
        public string RouteName => actionContext.ActionDescriptor.AttributeRouteInfo?.Name;
        public string Link => 
            actionContext.HttpContext.Request.Query.ContainsKey("query") ?
                urlHelper.Action(
                    actionContext.HttpContext.Request.Query["link_action"],
                    actionContext.HttpContext.Request.Query["link_controller"],
                    actionContext.HttpContext.Request.Query
                        .Where(kvp => kvp.Key != "link" && kvp.Key != "link_action" && kvp.Key != "link_controller")
                        .ToDictionary(kvp => kvp.Key.Substring("link_".Length), kvp => (object)kvp.Value[0]))
            : null;
    }
}
