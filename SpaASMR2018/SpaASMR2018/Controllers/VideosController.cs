using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.Controllers
{
    public class VideosController : Controller
    {
        private SpaAsmrDbContext _context; 

        public VideosController()
        {
            _context = new SpaAsmrDbContext();
        }        

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Video
        [HttpGet]
        public ActionResult Index()
        {
            List<Video> videos = new List<Video>();
            videos = _context.Videos.ToList();

            var videosViewModel = new VideosViewModel
            {
                Videos = videos
            };         

            return View(videosViewModel);
        }       
    }
}