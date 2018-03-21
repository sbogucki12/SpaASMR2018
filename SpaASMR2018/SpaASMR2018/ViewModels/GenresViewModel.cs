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
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public List<SelectListItem> Languages { get; set; }
        public List<SelectListItem> Genders { get; set; }
        public List<SelectListItem> Genres { get; set; }
        public List<Video> Videos { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserInput { get; set; }
    }
}