﻿using AuthenticationCode.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class Video
    {

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(255)]
        public string Language { get; set; }

        public string Length { get; set; }
        
        public int? VideoGenreId { get; set; }
        public string VideoGenre { get; set; }

        public int? ArtistId { get; set; }
        public string ArtistName { get; set; }   
        
        public ICollection<FavoriteVideo> FavoriteVideo { get; set; }
        
    }
}