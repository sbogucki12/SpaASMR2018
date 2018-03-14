using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Video> Favorites { get; set; }
    }
}