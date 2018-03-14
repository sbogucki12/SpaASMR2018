using AuthenticationCode.Models;
using Microsoft.AspNet.Identity;
using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpaASMR2018.Controllers.api
{
    public class FavoritesController : ApiController
    {
        private SpaAsmrDbContext _context;
        private ApplicationDbContext _userContext; 

        public FavoritesController()
        {
            _context = new SpaAsmrDbContext();
            _userContext = new ApplicationDbContext();
        }

        [HttpGet]
        public Video Get()
        {
            var videoToReturn = _context.Videos.FirstOrDefault(v => v.Id == 1);

            return videoToReturn;
        }

        [HttpPost]
        public ApplicationUser Post([FromBody]Video video)
        {
            //var id = RequestContext.Principal.Identity.GetUserId();
            var selectedUser = _userContext.Users.FirstOrDefault(u => u.Id == "9079c8be-b2ae-4070-be26-634a9392371d");


            if (selectedUser == null)
                throw new Exception("No such user");

            selectedUser.Video1Artist = video.ArtistName;
            selectedUser.Video1Name = video.Name;
            selectedUser.Video1Url = video.Url;
            _userContext.SaveChanges();

            return selectedUser;
        }
    }
}
