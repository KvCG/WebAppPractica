using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPractica.Models;
using WebAppPractica.ViewModels;

namespace WebAppPractica.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { name = "L4D2" };
            //otras alternativas para pasar datos a la vista pero en realidad son un dolor mantenerlas
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            var customers = new List<Customer> {
                new Customer{ id = 1, name = "Kevin" },
                new Customer{ id = 2, name = "Tita" }
            };

            var viewModel = new RandomMovieViewModel{
                Movie = movie,
                Customers = customers
            };
       
            return View( viewModel );
        }

        public ActionResult Edit( int id) {
            return Content("ID = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy) {// pageIndex es opcional
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month) { 
        
            return Content(year + "/" + month);
        }
    }
}