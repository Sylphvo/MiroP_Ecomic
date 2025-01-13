using Microsoft.AspNetCore.Mvc;
using MiroP_Ecomic.Core.Constants;

namespace MiroP_Ecomic_Web.Areas.Controllers
{
    public class HomeController : Controller
    {
        [Route(PortalEndpoint.Home.HomeEndpoint)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
