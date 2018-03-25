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
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public HomeController()
        {
            _context = new SpaAsmrDbContext();            
        }

        public ActionResult Index()
        {
            logger.Debug("Home Debug Information:");
            logger.Info("Home Info Information:");
            logger.Trace("Home Trance Information");

            var selectedVideos = _context.Videos.ToList();
            var viewModel = new GenresViewModel
            {
                Videos = selectedVideos,            
            };
            viewModel.Languages = new List<SelectListItem>
            {
                new SelectListItem{ Value="English", Text="English"},
                new SelectListItem{ Value="Russian", Text="Russian"}
            };
            viewModel.Genders = new List<SelectListItem>
            {
                new SelectListItem{ Value="Female", Text="Female"},
                new SelectListItem{ Value="Male", Text="Male"}
            };
            viewModel.Genres = new List<SelectListItem>
            {
                new SelectListItem{ Value="1", Text="Verbal (Affirmations, Whispering, etc.)"},
                new SelectListItem{ Value="2", Text="Objects (Mostly Non-Verbal"},
                new SelectListItem{ Value="3", Text="Roleplays (Characters and Miscellaneous)"},
                new SelectListItem{ Value="4", Text="Exam Roleplays (Dr. Visits, Spas, Massages, etc.)"}
            };
            viewModel.Length = new List<SelectListItem>
            {
                new SelectListItem{ Value="Short", Text="30 Minutes or Less"},
                new SelectListItem{ Value="Long", Text="31 Minutes or Longer"}
            };
        
            return View(viewModel);   
        }

        public ActionResult Error()
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