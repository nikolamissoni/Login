using Login.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Zaposlenik z = new Zaposlenik();
            z.UserName = "nikola";
            z.Password = "1234";
            List<Zaposlenik> lista = new List<Zaposlenik>();
            lista.Add(z);
            return View(lista);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Edit(Zaposlenik zaposlenik)
        {
            //return View("Edit");
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika.Add(zaposlenik);
            return View("Edit", listaZaposlenika);
        }
    }
}