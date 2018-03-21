using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class Artist
    {
        [Required]
        public int Id { get; set; }
        public string Image { get; set; }
        public string YoutubeUrl { get; set; }
        [MaxLength]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [ForeignKey("Video")]
        public int? VideoId { get; set; }
        public Video Video { get; set; }
    }
}