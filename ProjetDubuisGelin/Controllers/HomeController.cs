using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetDubuisGelin.Models;
using ProjetDubuisGelin.Models.UtilisateurViewModel;

namespace ProjetDubuisGelin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Connexion()
        {
            return View();
        }

        public IActionResult Inscription()
        {
            var NewUser = new UtilisateurRegistrationViewModel();
            return View(NewUser);
        }

        [HttpPost]
        public IActionResult Inscription(UtilisateurRegistrationViewModel User)
        {

            return View();
        }
    }
}