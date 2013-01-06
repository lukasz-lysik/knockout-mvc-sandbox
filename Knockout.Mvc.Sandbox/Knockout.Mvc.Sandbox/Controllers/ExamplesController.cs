using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Knockout.Mvc.Sandbox.Models;

namespace Knockout.Mvc.Sandbox.Controllers
{
    public class ExamplesController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new ExamplesIndexViewModel
            {
                Requirements = new List<AdditionalRequirement>
                {
                    new AdditionalRequirement { Id = 7, Description = "Kto?"},
                    new AdditionalRequirement { Id = 12, Description = "Gdzie?"},
                    new AdditionalRequirement { Id = 14, Description = "Kiedy?"},
                    new AdditionalRequirement { Id = 15, Description = "Ile?"}
                }
            };

            return View(viewModel);
        }
    }
}
