using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.ViewModels
{
    public class UserViewModel
    {
        public string Id; 
        public string Name;
        public string VideoName;
        public string VideoArtist;
        public string VideoUrl;
        public ICollection<Favorite> Favorites;
    }
}