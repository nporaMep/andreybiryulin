using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Net;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.PlatformAbstractions;

namespace AndreyBiryulin.Controllers
{
    public class ReturnTypesController : Controller
    {
        private IApplicationEnvironment environment;

        public ReturnTypesController(IApplicationEnvironment environment)
        {
            this.environment = environment;
        }

        [Route("[controller]", Name ="ReturnType")]
        public IActionResult Index() => View();
        [Route("[controller]/[action]", Name = "Msg")]
        public string Message(string message) => message;

        public IActionResult ControllerContent() => Content("{ id = 1 }", "application/json");
        public IActionResult ControllerCreated() => Created("http://someurl", null);
        public IActionResult ControllerCreatedAtAction() => CreatedAtAction("Message", "ReturnTypes", new { message = "CreatedAtActionResult" }, null);
        public IActionResult ControllerCreatedAtRoute() => CreatedAtRoute("ReturnType", null, null);
        public IActionResult ControllerFileContent() => File(System.IO.File.ReadAllBytes("files/ReturnTypeFile.txt"), "text/plain", "ReturnTypeFile.txt");
        public IActionResult ControllerFileStream() => File(System.IO.File.OpenRead("files/ReturnTypeFile.txt"), "text/plain", "ReturnTypeFile.txt");
        public IActionResult ControllerFileVirtual() => File("~/files/ReturnTypeFile.txt", "plain/text", "ReturnTypeFile.txt");
        public IActionResult ControllerHttpBadRequest() => HttpBadRequest(new { message = "Bad request message" });
        public IActionResult ControllerHttpNotFound() => HttpNotFound(new { message = "Not found message" });
        public IActionResult ControllerHttpUnauthorized() => HttpUnauthorized();
        public IActionResult ControllerJson() => Json(new { prop1 = 1, prop2 = 2, propList = new { propList1 = "Abc", propList2 = "cDE" } });
        public IActionResult ControllerLocalRedirect() => LocalRedirect("~/ReturnTypes");
        public IActionResult ControllerLocalRedirectPermanent() => LocalRedirectPermanent("~/ReturnTypes");
        public IActionResult ControllerOk() => Ok(new { message = "OK message" });
        public IActionResult ControllerPhysicalFile() => PhysicalFile(environment.ApplicationBasePath + "/wwwroot/files/ReturnTypeFile.txt", "plain/text", "ReturnTypeFile.txt");
        public IActionResult ControllerRedirect() => Redirect("http://wikipedia.org");
        public IActionResult ControllerRedirectPermanent() => RedirectPermanent("http://wikipedia.org");
        public IActionResult ControllerRedirectToAction() => RedirectToAction("Message", "ReturnTypes",
            new { message = "temporarily redirected via RedirectToActionResult" });
        public IActionResult ControllerRedirectToActionPermanent() => RedirectToActionPermanent("Message", "ReturnTypes",
            new { message = "permanently redirected via RedirectToActionResult" });
        public IActionResult ControllerRedirectToRoute() => RedirectToRoute("Msg", new { message = "temporarily redirected via RedirectToRouteResult" });
        public IActionResult ControllerRedirectToRoutePermanent() => RedirectToRoutePermanent("Msg", new { message = "permanently redirected via RedirectToRouteResult" });
        public IActionResult ControllerPartialView() => PartialView("_TestPartialView");
        public IActionResult ControllerView() => View("TestView");
        public IActionResult ControllerViewComponent() => ViewComponent("ReturnType", 5);


        public IActionResult BadRequestObject() => new BadRequestObjectResult(new { message = "bad request!" });
        public IActionResult BadRequest() => new BadRequestResult();
        public IActionResult Challenge() => new ChallengeResult();
        public IActionResult Content() => new ContentResult() {
            Content = "some content",
            ContentType = new MediaTypeHeaderValue("text/plain"),
            StatusCode = (int)HttpStatusCode.OK
        };
        public IActionResult CreatedAtAction() => new CreatedAtActionResult("Message", "ReturnTypes", new { message = "CreatedAtActionResult" }, null);
        public IActionResult CreatedAtRoute() => new CreatedAtRouteResult("ReturnType", null, null);
        public IActionResult Created() => new CreatedResult("http://someurl", null);
        public IActionResult Empty() => new EmptyResult();
        public IActionResult FileContent() => new FileContentResult(System.IO.File.ReadAllBytes("files/ReturnTypeFile.txt"), new MediaTypeHeaderValue("text/plain"));
        public IActionResult FileStream() => new FileStreamResult(System.IO.File.OpenRead("files/ReturnTypeFile.txt"), new MediaTypeHeaderValue("text/plain"));
        public IActionResult LocalRedirectTemp() => new LocalRedirectResult("~/ReturnTypes", false);
        public IActionResult LocalRedirectPermanent() => new LocalRedirectResult("~/ReturnTypes", true);
        public IActionResult NoContent() => new NoContentResult();
        public IActionResult NotFoundObject() => new HttpNotFoundObjectResult(new { message = "not found object" });
        public IActionResult NotFound() => new HttpNotFoundResult();
        public IActionResult Object() => new ObjectResult(new { prop1 = 1, prop2 = "abc" });
        public IActionResult OKObject() => new HttpOkObjectResult(new { message = "ok object" });
        public IActionResult OK() => new HttpOkResult();
        public IActionResult PhysicalFile() => new PhysicalFileResult(environment.ApplicationBasePath + "/wwwroot/files/ReturnTypeFile.txt", "plain/text") { FileDownloadName = "ReturnTypeFile.txt" };
        public IActionResult RedirectTemp() => new RedirectResult("http://wikipedia.org", false);
        public IActionResult RedirectPermanent() => new RedirectResult("http://wikipedia.org", true);
        public IActionResult RedirectToAction() => new RedirectToActionResult("Message", "ReturnTypes", 
            new Dictionary<string, object>() { { "message", "redirected via RedirectToActionResult" } });
        public IActionResult RedirectToRoute() => new RedirectToRouteResult("Msg", new { message = "redirected via RedirectToRouteResult" });
        public IActionResult StatusCode() => new HttpStatusCodeResult(200);
        public IActionResult Unauthorized() => new HttpUnauthorizedResult();
        public IActionResult UnsupportedMediaType() => new UnsupportedMediaTypeResult();
        public IActionResult VirtualFile() => new VirtualFileResult("~/files/ReturnTypeFile.txt", "plain/text") { FileDownloadName = "RetunTypeFile.txt" };
    }
}
