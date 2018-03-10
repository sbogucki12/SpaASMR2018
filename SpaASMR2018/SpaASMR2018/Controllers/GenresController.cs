using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.Controllers
{
    public class GenresController : Controller
    {
        private SpaAsmrDbContext _context;

        public GenresController()
        {
            _context = new SpaAsmrDbContext();
        }

        // GET: Genres
        [HttpGet]
        [Route("api/genres/{id}")]
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
    }
}