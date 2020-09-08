using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            //FormsAuthentication.SignOut();
            return View("Login");
        }

        [HttpPost]
        public ActionResult Index(Zaposlenik zaposlenik)
        {

            if (zaposlenik.UserName.Equals("nikola") && zaposlenik.Password.Equals("1234"))
            {
                FormsAuthentication.SetAuthCookie(zaposlenik.UserName, false);
                return RedirectToAction("Index", "Home", zaposlenik);
            }
            //}

            ModelState.AddModelError("", "Neuspješna Prijava");
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}