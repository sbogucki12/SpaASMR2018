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

        // GET: Artist
        [Route("artist/index/artistpage/{id}")]
        public ActionResult Index(int id)
        {
            var selectedArtist = _context.Artists.First(a => a.Id == id);

            if (selectedArtist == null)
                throw new Exception("Bad Artist Id");

            var artistVideos = _context.Videos.Where(a => a.ArtistId == id).ToList();

            var viewModel = new ArtistViewModel
            {
                ArtistName = selectedArtist.Name,
                ArtistImage = selectedArtist.Image,
                ArtistYtUrl = selectedArtist.YoutubeUrl,
                ArtistDescription = selectedArtist.Description,
                ArtistVideos = artistVideos
            };                   

            return View(viewModel);
        }
    }
}