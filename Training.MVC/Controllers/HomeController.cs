using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Training.MVC.Factory.Users;
using Training.MVC.Models;

namespace Training.MVC.Controllers
{
    [TrainingAuthorize(Roles ="Administrator")]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //List<Person> persons = null;
            //var email = persons[1].Email;

            IUserFactoryApi userFactoryApi = new UserFactoryApi();
            var firstName = userFactoryApi.GetUserFirstName();

            this.SuccessNotification("Success Called");
             return View();
        }

        //[TrainingAuthorize(Roles = "User")]
        
        public ActionResult Person(Person vm)
        {
            ModelState.Clear();
            return View(vm);
        }

        public ActionResult Person2(Person vm)
        {
            ModelState.Clear();
            return View(vm);
        }

        public ActionResult SavePerson2(Person vm)
        {
            this.SuccessNotification("Saved!");
            var viewstring = this.RenderPartialViewToString("_Message", null);
            return Json(viewstring);
        }


        public ActionResult SavePerson(Person vm)
        {
            var line1 = vm.MailingAddresses.AddressLine1;

            if (ModelState.IsValid)
            {
                //Make A Notification
                this.SuccessNotification("Saved!");
            }
             
            //Redirect To View
            return RedirectToAction("Person",vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product " + i });
            }
            ViewBag.Albums = albums;
            ViewData["Albums"] = albums;
            TempData["Albums"] = albums;

            return View();
        }

        public ActionResult List2()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product " + i });
            }
            return View(albums);
        }
        
        public ActionResult Message()
        {
            ViewBag.Message = "This is a partial view.";
            return PartialView();
        }
    }
}