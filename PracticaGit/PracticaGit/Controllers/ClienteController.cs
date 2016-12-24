using PracticaGit.Models.AccesoDatos;
using PracticaGit.Models.LogicaNegocio;
using PracticaGit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaGit.Controllers
{
    public class ClientesController : Controller
    {
        GestorClientes gestorClientes = new GestorClientes();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Guardar(Persona persona)
        {

            gestorClientes.Guardar(persona);
            return RedirectToAction("Listar");
        }
    }
}