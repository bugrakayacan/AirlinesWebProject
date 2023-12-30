using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webprojectplanebooking.Entities;

namespace webprojectplanebooking.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public AdminController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var users = _databaseContext.Users.ToList();
            return View(users);
        }
    }
}
