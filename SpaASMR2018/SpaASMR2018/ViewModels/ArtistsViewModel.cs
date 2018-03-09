using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.ViewModels
{
    public class ArtistsViewModel
    {

        public string ArtistName { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
    }
}