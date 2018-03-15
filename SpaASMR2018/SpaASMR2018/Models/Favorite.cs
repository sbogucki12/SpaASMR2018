using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class Favorite
    {
        public int? Id { get; set; }
        public string PlaylistName { get; set; }

        public string AspNetUserId { get; set; }

        public string VideoName { get; set; }
        public string VideoUrl { get; set; }
        public string VideoArtistGender { get; set; }
        public string VideoLanguage { get; set; }
        public string VideoGenre { get; set; }
        public string VideoArtistName { get; set; }
        

        public int? VideoId { get; set; }
        public Video Video { get; set; }

        public ICollection<FavoriteVideo> FavoriteVideo { get; set; }
    }
}