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
        public static List<Clientes> emList = new List<Clientes>
        {
            new Clientes
            {
                ID = 1,
                Nombre = "Hugo",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad = 10,
            },
            new Clientes
            {
                ID = 2,
                Nombre = "Paco",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad = 11,
            },
             new Clientes
             {
                ID = 3,
                Nombre = "Luis",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad = 12,
            },
            new Clientes
            {
                ID = 4,
                Nombre = "Tio Rico",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                Edad = 30,
            }
        };

        private EmpDBContext db = new EmpDBContext();

        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = from e in db.Clientes
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
        public ActionResult Create(Clientes emp)
        {
            try
            {
                // TODO: Add insert logic here
                db.Clientes.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5 *** Se usa para cargar la informacion y poder ser editada
        public ActionResult Edit(int id)
        {
            var clientes = db.Clientes.Single(m => m.ID == id);
            return View(clientes);
        }

        // POST: Clientes/Edit/5 *** Se usa para poder tomar toda la informacion y guardar en el modelo, despues llama a mostra la info
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var clientes = db.Clientes.Single(m => m.ID == id);
                if (TryUpdateModel(clientes))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(clientes);
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
                new Clientes
                {
                    ID = 1,
                    Nombre = "Hugo",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 10,
                },
                new Clientes
                {
                    ID = 2,
                    Nombre = "Paco",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 11,
                },
                 new Clientes
                 {
                    ID = 3,
                    Nombre = "Luis",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 12,
                },
                new Clientes
                {
                    ID = 4,
                    Nombre = "Tio Rico",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 30,
                }
            };
        }
    }
}
