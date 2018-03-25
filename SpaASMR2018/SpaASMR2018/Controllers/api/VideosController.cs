using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpaASMR2018.Controllers.api
{
    public class VideosController : ApiController
    {
        private SpaAsmrDbContext _context;

        public VideosController()
        {
            _context = new SpaAsmrDbContext();
        }
        [HttpGet]
        public HttpResponseMessage Get(string gender, int genre, string language, string length)
        {

            var selectedVideos = _context.Videos
                .Where(v => v.Gender == gender)
                .Where(v => v.VideoGenreId == genre)
                .Where(v => v.Language == language)
                .Where(v => v.Length == length)
                .ToList();

            var badResponse = Request.CreateResponse(HttpStatusCode.NotFound);
            var goodResponse = Request.CreateResponse(HttpStatusCode.Moved);
            var redirectUrl = Request.RequestUri.GetLeftPart(UriPartial.Authority);
            goodResponse.Headers.Location = new Uri(redirectUrl + "/" + "genre" + "/" + "getvideos" + "?" + "language=" + language + "&gender=" + gender + "&genreId=" + genre + "&length=" + length);
           

            if (selectedVideos == null)
                return badResponse;

            return goodResponse;

        }
    }
}
