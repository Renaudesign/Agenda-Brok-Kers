using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brokers.Models;

namespace Brokers.Views.Home
{
    public class HomeController : Controller
    {
        agendaEntities db = new agendaEntities();
        public ActionResult Index()
        {

            var appointments = db.appointments.ToList();
            return View(appointments);
        }
    }
}