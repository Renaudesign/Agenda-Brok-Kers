using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brokers.Models;

namespace Brokers.Controllers
{
    public class BrokersController : Controller
    {
        agendaEntities db = new agendaEntities();

        //Retourner à la page d'acceuil ( l'agenda )
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        //afficher la page d'ajout de courtier
        [HttpGet]
        public ActionResult AddBroker()
        {
            return View();
        }

        //enregistrer le nouveau courtier
        [HttpPost]
        public ActionResult AddBroker(brokers broker)
        {
            if (ModelState.IsValid)
            {
                db.brokers.Add(broker);
                db.SaveChanges();
                TempData["Success"] = "Courtier enregistré avec succès";
                return View();
            }
            return View();
        }

        //Afficher la liste des courtiers
        public ActionResult ListBrokers()
        {
            var brokers = db.brokers.ToList();
            return View(brokers);
        }

        //Afficher les détails du courtier
        public ActionResult DetailsBroker(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var brokerDetails = db.brokers.Find(id);
            if (brokerDetails == null)
            {
                return HttpNotFound();
            }
            return View(brokerDetails);
        }

        //Ouvrir la page d'édition du courtier
        public ActionResult EditBroker(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var brokerDetails = db.brokers.Find(id);
            if (brokerDetails == null)
            {
                return HttpNotFound();
            }
            return View(brokerDetails);
        }

        //enregistrer les modifications du courtier
        [HttpPost]
        public ActionResult EditBroker(brokers broker)
        {
            if (ModelState.IsValid)
            {
                var lastname = broker.lastname;
                var firstname = broker.firstname;
                var mail = broker.mail;
                var phone = broker.phoneNumber;
                db.SaveChanges();
                TempData["Success"] = "Courtier "+ lastname +" modifié avec succès";
                return View();
            }
            return View();
        }


        [HttpGet]
        public ActionResult DeleteBroker(brokers broker)
        {
            return View("ListBrokers");
        }


        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult DeleteBroker(String inputBroker, int idbroker)
        {
            int id = idbroker;
            var broker = db.brokers.Find(id);
            var brokerName = broker.lastname;
            var brokers = db.brokers.ToList();
            if (inputBroker == brokerName)
                {
                db.brokers.Remove(broker);
                db.SaveChanges();
                TempData["Success"] = "Courtier " + broker.lastname + " supprimé";
                return View();
            }
            TempData["Failure"] = "Saisie incorrecte";
            return View("ListBrokers", brokers);
        }



    }
}

