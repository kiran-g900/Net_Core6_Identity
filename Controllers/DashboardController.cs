using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetsix_Identity.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {       
        public IActionResult Display()
        {
            return View();
        }
    }
}
