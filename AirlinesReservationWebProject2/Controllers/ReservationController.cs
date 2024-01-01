using AirlinesReservationWebProject2.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlinesReservationWebProject2.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {

        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public ReservationController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        public async Task<IActionResult> Flight()
        {

            return _databaseContext.Flights != null ?
                            View(await _databaseContext.Flights.ToListAsync()) :
                            Problem("Entity set 'DatabaseContext.Flights'  is null.");
            
        }
        public async Task<IActionResult> MyFlight()
        {
            return _databaseContext.Flights != null ?
                View(await _databaseContext.Flights.ToListAsync()) :
                Problem("Entity set 'DatabaseContext.Flights'  is null.");
        }
    }
}
