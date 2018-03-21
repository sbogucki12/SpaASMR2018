using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.ViewModels
{
    public class ArtistViewModel
    {
        public int? Id { get; set; }
        public string ArtistName { get; set; }
        public string ArtistImage { get; set; }
        public ICollection<Video> ArtistVideos { get; set; }
        public string ArtistYtUrl { get; set; }
        public string ArtistDescription { get; set; }
    }
}