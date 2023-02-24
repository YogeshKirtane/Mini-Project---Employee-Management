using Employee_Mini_Proj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Mini_Proj.Controllers
{
    public class LoginController : Controller
    {
        private readonly MiniprojContext _context;

        public LoginController(MiniprojContext context)
        {
            _context = context;
        }

        // GET: LoginController
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login log)
        {
            bool isValid = _context.Employees.Any(u => u.Username == log.Username && u.Password == log.Password);
            if (isValid)
            {
                //FormsAuthentication.SetAuthCookie(emp.Username, false);
                return RedirectToAction("Index", "Employees");
            }

            ModelState.AddModelError("", "Invalid Username/Password!");
            return View();
        }
    }
}
