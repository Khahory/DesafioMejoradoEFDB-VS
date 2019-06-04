using DesafioMejorado_DataBaseFirst.Service;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioMejorado_DataBaseFirst.Controllers
{
    public class PersonaController : Controller
    {
        //https://www.youtube.com/watch?v=IKlmroHxDNc&t=1442s
        private PersonaService _repo;

        ADO_ContextDB db;
        //constructor
        public PersonaController()
        {
            db = new ADO_ContextDB();
            _repo = new PersonaService();
        }

        // GET: Persona
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        public ActionResult CreatePDF_index()
        {
            return new ActionAsPdf("Index");
        }

        public ActionResult CreatePDF_details(int id)
        {
            var x = db.PersonaSet.Find(id);
            return new ActionAsPdf("DetailsPDF", x);
        }

        public ActionResult DetailsPDF(int id)
        {
            var model = db.PersonaSet.Find(id);
            return View("DetailsPDF", model);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            
            var model = db.PersonaSet.Find(id);
            return View(model);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(PersonaSet model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //este modelo se enviara a crear, luego se enviara al MODELO de BlogPostModel (y despues de ahi a la DB)
                    _repo.Crear(model);

                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                //log ex
            }
            return View(model);
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
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
    }
}
