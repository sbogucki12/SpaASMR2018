using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaASMR2018.ViewModels
{
    public class GenresViewModel
    {
        public string Name;
        public string Gender;
        public string Genre;
        public string Language;
        public List<SelectListItem> Languages;
        public List<SelectListItem> Genders;
        public List<SelectListItem> Genres;
        public List<Video> Videos;        
        public string UserName;        
        public string UserEmail;        
        public string UserInput; 
    }
}