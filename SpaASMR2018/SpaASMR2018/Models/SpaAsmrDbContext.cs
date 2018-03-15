using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class SpaAsmrDbContext : DbContext
    {

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoGenre> VideoGenres { get; set; }  
        public DbSet<FavoriteVideo> FavoriteVideo { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        public SpaAsmrDbContext()
            :base("DefaultConnection")
        {

        }

        public static SpaAsmrDbContext Create()
        {
            return new SpaAsmrDbContext();
        }
    }
}