using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class Playlist
    {
        public int? Id { get; set; }
        public string PlaylistName { get; set; }

        public List<Video> Videos { get; set; }
    }
}