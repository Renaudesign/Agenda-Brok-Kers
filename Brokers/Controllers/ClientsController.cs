using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brokers.Models;

namespace Brokers.Controllers
{
    public class ClientsController : Controller
    {
        agendaEntities db = new agendaEntities();
        //afficher la page d'ajout de client
        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        //enregistrer le nouveau client
        [HttpPost]
        public ActionResult AddClient(customers client)
        {
            if (ModelState.IsValid)
            {
                db.customers.Add(client);
                db.SaveChanges();
                TempData["Success"] = "Client "+ client.lastname + " enregistré avec succès";
                return View();
            }
            return View();
        }

        //Afficher la liste des clients
        public ActionResult ListClients()
        {
            var customers = db.customers.ToList();
            return View(customers);
        }

        //Afficher les détails du client
        public ActionResult DetailsClient(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var customersDetails = db.customers.Find(id);
            if (customersDetails == null)
            {
                return HttpNotFound();
            }
            return View(customersDetails);
        }

        //Ouvrir la page d'édition du Client
        public ActionResult EditClient(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var customersDetails = db.customers.Find(id);
            if (customersDetails == null)
            {
                return HttpNotFound();
            }
            return View(customersDetails);
        }

        //enregistrer les modifications du client
        [HttpPost]
        public ActionResult EditClient(customers client)
        {
            if (ModelState.IsValid)
            {
                var lastname = client.lastname;
                var firstname = client.firstname;
                var mail = client.mail;
                var phone = client.phoneNumber;
                var budget = client.budget;
                db.SaveChanges();
                TempData["Success"] = "Client modifié avec succès";
                return View();
            }
            return View();
        }




    }
}
