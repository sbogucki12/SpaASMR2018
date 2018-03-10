using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.ViewModels
{
    public class GenresViewModel
    {
        public string Name;
        public string Gender;
        public string Genre;
        public string Language; 
        public List<Video> Videos; 
    }
}