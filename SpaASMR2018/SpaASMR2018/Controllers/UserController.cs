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


        // GET: User
        [Authorize]
        public ActionResult Index(int favoriteId)
        {
            var id = User.Identity.GetUserId();
            var selectedUser = _usercontext.Users.FirstOrDefault(u => u.Id == "9079c8be-b2ae-4070-be26-634a9392371d");
            var favorites = _context.FavoriteVideo.Where(f => f.AspNetUsersId == id).Where(f => f.FavoriteId == favoriteId).ToList();

            if (selectedUser == null)
                throw new Exception("No such user");

            var userViewModel = new UserViewModel
            {
                Id = selectedUser.Id,
                Name = selectedUser.UserName,
                FavoriteVideos = favorites
                //Video1Artist = selectedUser.Video1Artist,
                //Video1Name = selectedUser.Video1Name,
                //Video1Url = selectedUser.Video1Url
            };      

            return View(userViewModel);
        }
    }
}