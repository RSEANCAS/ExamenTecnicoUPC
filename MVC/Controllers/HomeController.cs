using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        DbUPCContext db = new DbUPCContext();
        // GET: Home
        public ActionResult Index()
        {
            List<OrdenCompra> listaOrdenCompra = db.OrdenCompra.ToList();

            ViewData["ListaOrdenCompra"] = listaOrdenCompra;

            return View();
        }
    }
}