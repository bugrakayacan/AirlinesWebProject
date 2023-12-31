using Microsoft.AspNetCore.Mvc;

namespace AirlinesReservationWebProject2.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Flight()
        {
            return View();
        }
        public IActionResult MyFlight()
        {
            return View();
        }
    }
}
