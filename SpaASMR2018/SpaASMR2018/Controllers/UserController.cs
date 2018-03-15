using AuthenticationCode.Models;
using Microsoft.AspNet.Identity;
using SpaASMR2018.Models;
using SpaASMR2018.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpaASMR2018.Controllers
{
    public class UserController : Controller
    {
        private SpaAsmrDbContext _context;
        private ApplicationDbContext _usercontext;

        public UserController()
        {
            _context = new SpaAsmrDbContext();
            _usercontext = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var listOfFavorites = _context.FavoriteVideo.Where(f => f.FavoriteId == 1);
            var currentUser = _usercontext.Users.FirstOrDefault(u => u.Id == id);

            var userViewModel = new UserViewModel
            {
                Name = currentUser.UserName,
                FavoriteVideos = listOfFavorites.ToList(),
                
                
            };

            return View(userViewModel);

            
        }

        // GET: User
        //[Authorize]
        //public ActionResult Index(/*int favoriteId*/)
        //{
        //    var id = User.Identity.GetUserId();
            //var selectedUser = _usercontext.Users.FirstOrDefault(u => u.Id == id);
            //var listOfVideos = _context.FavoriteVideo.Where(u => u.AspNetUsersId == id).ToList();
            //var favoriteVideos = ApplicationUser.



            //if (favorites == null)
            //    throw new Exception("No such user");

            //var userViewModel = new UserViewModel
            //{
            //    Id = id,
            //    Name = "Steve",
            //    FavoriteVideos = favorites.ToList()
                
                //Video1Artist = selectedUser.Video1Artist,
                //Video1Name = selectedUser.Video1Name,
                //Video1Url = selectedUser.Video1Url
    //        };      

    //        return View(userViewModel);
    //    }
    }
}