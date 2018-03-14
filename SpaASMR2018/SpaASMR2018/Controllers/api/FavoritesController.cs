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
        public FavoritesController()
        {
            _context = new SpaAsmrDbContext();
        }

        [HttpGet]
        public Video Get()
        {
            var videoToReturn = _context.Videos.FirstOrDefault(v => v.Id == 1);

            return videoToReturn;
        }


        [HttpPost]
        public Video Post([FromBody]Video video)
        {
            var steve = new User();
            steve.Favorites = new List<Video>();
            var video1 = new Video();
            video1.Id = video.Id.Value;
            video1.Language = video.Language.ToString();
            video1.Name = video.Name.ToString();
            video1.Url = video.Url.ToString();
            video1.VideoGenre = video.VideoGenre.ToString();
            video1.VideoGenreId = video.VideoGenreId.Value;
            video1.Gender = video.Gender.ToString();
            video1.ArtistName = video.ArtistName.ToString();
            video1.ArtistId = video.ArtistId.Value;

            steve.Favorites.Add(video1);


            return steve.Favorites.Last();
        }
    }
}
