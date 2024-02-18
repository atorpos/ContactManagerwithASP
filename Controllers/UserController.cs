using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class UserController : Controller
    {
        private UserContext context { get; set; }

        public UserController(UserContext ctx)
        {
            context = ctx;
        }

        [HttpGet]

        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("Edit", new User());
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        
        public IActionResult AddContact(User user)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(user);
            }
        }
        
        public IActionResult AddContact()
        {
            return View();
        }

        public IActionResult ContactDetails()
        {
            return View();
        }
        // public IActionResult Edit()
        // {
        //     return View();
        // }

        public IActionResult DeletePage() {
            return View();
        }
    }
}

