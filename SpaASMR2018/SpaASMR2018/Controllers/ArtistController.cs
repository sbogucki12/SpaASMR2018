using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.Controllers
{
    public class ArtistController : Controller
    {
        private SpaAsmrDbContext _context;

        public ArtistController()
        {
            _context = new SpaAsmrDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Artists
        public ActionResult Index()
        {

            var videos = _context.Videos.Where(v => v.ArtistId == 8).ToList();

            ArtistsViewModel artistsViewModel = new ArtistsViewModel
            {
                Videos = videos
            };

            return View(artistsViewModel);
        }

        public ActionResult Artist(int? id)
        {

            var selectedVideos = _context.Videos.Where(v => v.ArtistId == id).ToList();

            if(id > selectedVideos.Count || id == null)
            {
                return HttpNotFound("There is no such artist in the database.");
            }

            var artistViewModel = new ArtistsViewModel
            {
                Videos = selectedVideos,
                ArtistName = selectedVideos[0].ArtistName
            };

            return View(artistViewModel);
        }
    }
}