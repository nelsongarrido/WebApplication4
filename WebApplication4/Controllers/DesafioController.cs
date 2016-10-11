using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class DesafioController : Controller
    {

        Models.AsapEntities _dbClient = new Models.AsapEntities();


        // GET: Desafio
        public ActionResult Index()
        {
            return View();
        }


        public void AddDesafio(Models.Desafio desafio)
        {
            _dbClient.Desafio.Add(desafio);
            _dbClient.SaveChanges();
        }

    }
}