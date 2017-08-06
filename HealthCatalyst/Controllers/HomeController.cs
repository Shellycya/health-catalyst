using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using HealthCatalyst.Context;
using HealthCatalyst.Models;

namespace HealthCatalyst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Person> model;


			using (var ctx = new PersonContext())
			{
                SeedPeople seedPeople = new SeedPeople();
                seedPeople.Seed(ctx);
                model = ctx.Persons.ToList<Person>();
			}

            return View(model);
        }

        public ActionResult SearchPeople(string keyword)
        {
            var ctx = new PersonContext();
            var data = ctx.Persons.Where(p => p.Name.Contains(keyword)).ToList();
            return PartialView("SearchPeople", data);
        }


    }
}
