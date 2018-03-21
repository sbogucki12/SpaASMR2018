using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string VideoName { get; set; }
        public string VideoArtist { get; set; }
        public string VideoUrl { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}