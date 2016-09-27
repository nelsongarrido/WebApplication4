using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var currentClaims = ClaimsPrincipal.Current;

            if (currentClaims.Identity.IsAuthenticated)
            {
                string name = currentClaims.FindFirst("name").Value;
                ViewBag.Name = name;
                ViewBag.Desafios = new Dictionary<string, string> { { "1", "Desafrio 1" }, {"2", "Desafio 2" } };
            }
            else ViewBag.Name = "";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult View1()
        {
            //var currentClaims = ClaimsPrincipal.Current;

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return RedirectToAction("View1");
        }

        public ActionResult Logout()
        {
            System.IdentityModel.Services.FederatedAuthentication.SessionAuthenticationModule.SignOut();

            return RedirectToAction("Index");
        }
    }
}