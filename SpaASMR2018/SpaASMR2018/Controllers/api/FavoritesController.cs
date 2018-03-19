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
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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

        [HttpGet]
        [Route("api/favorites/getlist")]
        public List<Video> GetList()
        {
            return _context.Videos.ToList();
        }


        [HttpPost]
        [Route("api/favorites/post/{id}")]
        public HttpResponseMessage Post(int id)
        {
            logger.Debug("Favorite Debug Information:");
            logger.Info("Favorite Info Information:");
            logger.Trace("Favorite Trance Information");
            var userId = RequestContext.Principal.Identity.GetUserId();
            if (userId == null)
            {
                HttpResponseMessage redirectResponse = Request.CreateResponse(HttpStatusCode.BadRequest);
                return redirectResponse;
            };

            //var testingId = "b553bde3-adc2-436e-9253-042a79aa4d84";
            var selectedUser = _userContext.Users.FirstOrDefault(u => u.Id == userId);
            var selectedVideo = _context.Videos.FirstOrDefault(v => v.Id == id);

            var favoriteToAdd = new Favorite
            {
                PlaylistName = "Steve's Playlist",
                AspNetUserId = userId,
                VideoArtistName = selectedVideo.ArtistName,
                VideoUrl = selectedVideo.Url,
                VideoArtistGender = selectedVideo.Gender,
                VideoLanguage = selectedVideo.Language,
                VideoGenre = selectedVideo.VideoGenre,
                VideoName = selectedVideo.Name,
                VideoId = selectedVideo.Id
            };

            _context.Favorites.Add(favoriteToAdd);
            _context.SaveChanges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Video saved to your list of Favorites!");
            return response;
        }

        
        [Route("api/favorites/remove/{id}")]
        public HttpResponseMessage Remove(int id)
        {
            //var testingId = "b553bde3-adc2-436e-9253-042a79aa4d84";
            var userId = RequestContext.Principal.Identity.GetUserId(); 
                
            if (userId == null)
            {
                HttpResponseMessage redirectResponse = Request.CreateResponse(HttpStatusCode.BadRequest);
                return redirectResponse;
            };
            var selectedVideo = _context.Favorites
                //.Where(f => f.AspNetUserId == userId)
                .FirstOrDefault(f => f.Id == id);

            _context.Favorites.Remove(selectedVideo);
            _context.SaveChanges();
            var videosToReturn = _context.Favorites.Where(f => f.AspNetUserId == userId);
            var response = Request.CreateResponse(HttpStatusCode.OK, videosToReturn);
            return response; 
        }

    }
}

