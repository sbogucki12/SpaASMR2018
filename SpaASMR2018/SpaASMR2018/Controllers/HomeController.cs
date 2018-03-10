using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.Controllers
{
    public class HomeController : Controller
    {

        private SpaAsmrDbContext _context;

        public HomeController()
        {
            _context = new SpaAsmrDbContext();
        }

        public ActionResult Index()
        {
            var selectedVideos = _context.Videos.ToList();

            var viewModel = new GenresViewModel
            {
                Videos = selectedVideos
            };

            return View(viewModel);   
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}