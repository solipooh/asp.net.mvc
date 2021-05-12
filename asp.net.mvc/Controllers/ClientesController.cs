using asp.net.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net.mvc.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = from e in TodosLosCientes()
                           orderby e.ID
                           select e;
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Clientes> TodosLosCientes()
        {
            return new List<Clientes>()
            {
                new Clientes{
                    ID = 1,
                    Nombre = "Hugo",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 30,
                },
                new Clientes{
                    ID = 2,
                    Nombre = "Paco",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 35,
                },
                new Clientes{
                    ID = 3,
                    Nombre = "Luis",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 40,
                }
            };
        }
    }
}
