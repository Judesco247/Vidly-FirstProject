using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shreks!" };
            var customer = new List<Customers>
            {
                new Customers { Name = "Customer 1"},
                new Customers { Name = "Customer 2"}
            };
            var viewModel = new RandomMoviesViewModel
            {
                Movies = movie,
                Customers = customer
            };
            return View(viewModel);
        }
    }
}