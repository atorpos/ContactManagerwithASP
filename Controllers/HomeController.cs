using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserContext context { get; set; }
        
        public HomeController(ILogger<HomeController> logger, UserContext ctx)
        {
            context = ctx;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = context.Users.Include(user1 => user1.UserId)
                .OrderBy(user1 => user1.UserId).ToList();
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
