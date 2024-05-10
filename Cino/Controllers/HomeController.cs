using Cino.DataFactory;
using Cino.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cino.Controllers
{

    public class HomeController : Controller
    {
        private List<Film> films = FilmFactory.CreateRandomFilms(10);
        public IActionResult Index()
        {
            return View(films);
        }
        public IActionResult Details(int id)
        {
            Film film = films.FirstOrDefault(f => f.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(films[0]);
        }
    }

}
