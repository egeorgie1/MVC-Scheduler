using System;
using Microsoft.AspNetCore.Mvc;
using MVCScheduler.Models;
using System.Linq;
namespace MVCScheduler.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult PresentationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult PresentationForm(Presentation presentation)
        {
            if (ModelState.IsValid)
            {
                Repository.AddNewPresentation(presentation);
                return View("Thanks", presentation);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListShorterPres()
        {
            return View("List", Repository.Presentations.Where(p => p.PresLength < 60));
        }

        public ViewResult ListAllPres()
        {
            return View("List", Repository.Presentations);
        }
    }
}