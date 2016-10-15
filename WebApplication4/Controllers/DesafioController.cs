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
            desafio.Controladora = "Home";

            switch (desafio.TipoDesafioID)
            {
                case 1:
                    desafio.Accion = "Desafio1";
                    break;
                case 2:
                    desafio.Accion = "Desafio2";
                    break;
            }

            _dbClient.Desafio.Add(desafio);
            _dbClient.SaveChanges();
        }

    }
}