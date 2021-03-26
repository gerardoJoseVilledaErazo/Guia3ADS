using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes/ListaClientes
        public ActionResult ListaClientes()
        {
            Cliente cliente1 = new Cliente() {Id = 1, Nombre = "Juan", Edad = 30, NumeroTelefono = "2255-2255", DUI = "0421569-4", Direccion = "El Pilar, Sonsonate" };
            return View(cliente1);
        }
    }
}