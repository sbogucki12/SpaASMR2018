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
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }

        [ForeignKey("VideoGenre")]
        public int? VideoGenreId { get; set; }
        public VideoGenre VideoGenre { get; set; }

        public int? ArtistId { get; set; }
        public string ArtistName { get; set; }
    }
}