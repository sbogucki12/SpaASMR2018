using AuthenticationCode.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class FavoriteVideo
    {
        public int? Id { get; set; }

        public int? VideoId { get; set; }
        public Video Video { get; set; }

        public int FavoriteId { get; set; }
        public Favorite Favorite { get; set; }

        public string AspNetUsersId { get; set; }        
    }
}