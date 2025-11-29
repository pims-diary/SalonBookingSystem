using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
    public class StaffController : Controller
    {
        // GET: /Staff/Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
