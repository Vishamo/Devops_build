using Devops_build.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devops_build.Controllers
{ 
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserInfo userInfo)
        {
            return View("Display", userInfo);
        }
    }
}
