﻿using AuthenticationCode.Models;
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
        public ICollection<FavoriteVideo> Post(int videoId, int favoriteId)
        {
            var id = RequestContext.Principal.Identity.GetUserId();
            //var selectedUser = _userContext.Users.FirstOrDefault(u => u.Id == id);
            //var favoriteVideos = _context.FavoriteVideo.Where(f => f.AspNetUsersId == id).Where(f => f.FavoriteId == favoriteId);
            var selectedFavorite = new FavoriteVideo
            {
                VideoId = videoId,
                AspNetUsersId = id,
                FavoriteId = favoriteId
            };
            _context.FavoriteVideo.Add(selectedFavorite);
            _context.SaveChanges();

            
            return _context.FavoriteVideo.Where(v => v.AspNetUsersId == id).ToList();




            //if(favoriteVideos == null)
            //{
            //    throw new Exception("No such list of favorite");
            //}

            //var videoToAdd = new Video
            //{
            //    Id = video.Id,
            //    Name = video.Name,
            //    Url = video.Url,
            //    Gender = video.Gender,
            //    Language = video.Language,
            //    VideoGenre = video.VideoGenre,
            //    VideoGenreId = video.VideoGenreId,
            //    ArtistId = video.ArtistId,
            //    ArtistName = video.ArtistName
            //};





            //return Ok(favoriteVideos);


            //selectedUser.Video1Artist = video.ArtistName;
            //selectedUser.Video1Name = video.Name;
            //selectedUser.Video1Url = video.Url;
            //_userContext.SaveChanges();

            //return selectedUser;
        }
    }
}
