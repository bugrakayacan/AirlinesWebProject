using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webprojectplanebooking.Controllers
{
	[Authorize]
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
