using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SpaASMR2018.Models;

namespace SpaASMR2018.Controllers.api
{
    public class PlaylistController : ApiController
    {
        private SpaAsmrDbContext _context;

        public PlaylistController()
        {
            _context = new SpaAsmrDbContext();
        }

        //[HttpPost]
        //[Route("api/playlist/add")]
        //public List<Video> AddVideoToPlaylist([FromBody]Video video)
        //{

        //    var stevePlaylist = new Playlist();


            //_context.Playlists.Add(playlist);     

            //_context.SaveChanges();


            //return _context.Playlists.ToList().Last();



        }
    
}
