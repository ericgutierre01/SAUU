using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SAUU.Helpers;
using System.Linq;

namespace SAUU.Controllers
{
    public class BaseController : Controller
    {
        public string _token = "";
        public readonly HttpClientAPI httpClient;
        public BaseController(HttpClientAPI config) => httpClient = config;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var _token = HttpContext.User.Claims.SingleOrDefault(x => x.Type == "token")?.Value;
            if (string.IsNullOrEmpty(_token))
                context.Result = new RedirectResult("~/logout");
        }
    }
}