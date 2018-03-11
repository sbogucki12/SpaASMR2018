using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.Controllers
{
    public class GenreController : Controller
    {
        private SpaAsmrDbContext _context;

        public GenreController()
        {
            _context = new SpaAsmrDbContext();
        }

        // GET: Genres
        [HttpGet]
        public ActionResult GetByGenre(int? id)
        {
            var selectedVideos = _context.Videos.Where(v => v.VideoGenreId == id).ToList();

            if (selectedVideos == null || id == null)
                throw new Exception("No such genre in database.");

            var viewModel = new GenresViewModel
            {
                Name = selectedVideos[0].VideoGenre,
                Videos = selectedVideos
            };

            return View(viewModel);
        }

        [HttpGet]
        [Route("genre/getvideos?language={language}&gender={gender}&genreId={genreId}")]
        public ActionResult GetVideos(string language, string gender, int? genreId)
        {
            var selectedVideos = _context.Videos.Where(v => (v.Gender == gender) && (v.VideoGenreId == genreId) && (v.Language == language)).ToList();

            if (selectedVideos == null)
                throw new Exception("No such videos in the directory.");


            var viewModel = new GenresViewModel
            {
                Videos = selectedVideos,
                Gender = selectedVideos[0].Gender,
                Genre = selectedVideos[0].VideoGenre,
                Language = selectedVideos[0].Language
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Test(string gender)
        {
            var selectedVideos = _context.Videos.Where(v => v.Gender == gender).ToList();

            if(selectedVideos == null)
            {
                throw new Exception("No such video.");
            }

            var viewModel = new GenresViewModel
            {
                Videos = selectedVideos,
                Gender = selectedVideos[0].Gender,
                Genre = selectedVideos[0].VideoGenre,
                Language = selectedVideos[0].Language
            };

            return View("getVideos", viewModel);
        }
    }
}