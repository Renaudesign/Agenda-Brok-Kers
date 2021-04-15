using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brokers.Models;

namespace Brokers.Controllers
{
    public class AppointmentsController : Controller
    {
        agendaEntities db = new agendaEntities();

        //afficher la page d'ajout de rdv
        [HttpGet]
        public ActionResult AddAppointment()
        {
            ViewBag.idBroker = new SelectList(db.brokers, "idBroker", "lastname");
            ViewBag.idCustomers = new SelectList(db.customers, "idCustomers", "lastname");
            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(appointments appointment)
        {
            ViewBag.idBroker = new SelectList(db.brokers, "idBroker", "lastname", appointment.idBroker);
            ViewBag.idCustomers = new SelectList(db.customers, "idCustomers", "lastname", appointment.idCustomers);
            return View(appointment);
        }

        //enregistrer le nouveau rdv
        [HttpPost]
        public ActionResult SaveAppointment(appointments appointment)
        {
            if (ModelState.IsValid)
            {
                db.appointments.Add(appointment);
                db.SaveChanges();
                TempData["Success"] = "Rendez-vous enregistré avec succès";
                return View();
            }
            return View("AddAppointment", appointment);
        }

        //Afficher la liste des rdv
        public ActionResult ListAppointments()
        {
            var appointments = db.appointments.ToList();
            return View(appointments);
        }


        //Afficher les détails du rdv
        [HttpGet]
        public ActionResult DetailsAppointment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var appointmentDetails = db.appointments.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View("DetailsAppointment", appointmentDetails);
        }

        //Ouvrir la page d'édition du rdv
        [HttpGet]
        public ActionResult EditAppointment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var appointmentDetails = db.appointments.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }

            ViewBag.idBroker = new SelectList(db.brokers, "idBroker", "lastname");
            ViewBag.idCustomers = new SelectList(db.customers, "idCustomers", "lastname");
            return View("EditAppointment", appointmentDetails);
        }

    }
}
