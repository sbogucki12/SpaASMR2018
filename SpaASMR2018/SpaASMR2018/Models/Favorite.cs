using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class Favorite
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public ICollection<FavoriteVideo> FavoriteVideo { get; set; }
    }
}