using Microsoft.AspNetCore.Mvc;

namespace DbMvcApp.Controllers
{
    public class AccessDenied : Controller
    {
        public IActionResult Deny()
        {
            return View();
        }
    }
}
