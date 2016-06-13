using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
                _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            //get the movies from the database
            IEnumerable<Movie> movies = _context.Movies.ToList();


            return View(movies);
        }

        public ActionResult Details(int id)
        {

            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            return View(movie);
        }
    }
}