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
        Models.AsapEntities _dbClient = new Models.AsapEntities();


        public ActionResult Index()
        {
            var currentClaims = ClaimsPrincipal.Current;

            if (currentClaims.Identity.IsAuthenticated)
            {
                string name = currentClaims.FindFirst("name").Value;
                var usuario = _dbClient.Usuario.FirstOrDefault(f => f.Email == name);

                ViewBag.Name = usuario?.Nombre ?? name;
                ViewBag.Desafios = usuario?.Desafios.ToList();
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

        public ActionResult Desafio1()
        {
            return PartialView("MyPartialViews/_Desafio1");
        }

        public ActionResult Desafio2()
        {
            return PartialView("MyPartialViews/_Desafio1");
        }

        public ActionResult CrearDesafio()
        {
            //var usuarioDesafioCustom = new List<Models.UsuarioDesafioCustom>();
            var usuarios = _dbClient.Usuario.Where(f => f.EsProfesor == false).ToList();

            //foreach (var u in usuarios)
            //{
            //    foreach (var d in u.Desafios)
            //    {
            //        var usd = new Models.UsuarioDesafioCustom();
            //        usd.User = u;
            //        usd.Desafio = d;

            //        usuarioDesafioCustom.Add(usd);
            //    }
            //}
            return PartialView("MyPartialViews/_CrearDesafio", usuarios);
        }

        //public ActionResult DeleteDesafioByUser()
        //{
            //bool result = true;
            //return Json(new { result }, JsonRequestBehavior.AllowGet);
            //var usuarioDesafioCustom = new List<Models.UsuarioDesafioCustom>();
            //var usuarios = _dbClient.Usuario.Where(f => f.EsProfesor == false).ToList();

            //foreach (var u in usuarios)
            //{
            //    foreach (var d in u.Desafios)
            //    {
            //        var usd = new Models.UsuarioDesafioCustom();
            //        usd.User = u;
            //        usd.Desafio = d;

            //        usuarioDesafioCustom.Add(usd);
            //    }
            //}
            //return PartialView("MyPartialViews/_CrearDesafio", usuarioDesafioCustom);
       // }
    }
}