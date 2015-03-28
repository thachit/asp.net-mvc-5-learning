using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcMusicStore.Models
{
    public class MusicStoreDB : DbContext
    {
        public MusicStoreDB() : base("name=MusicStoreDB")
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; } 
    }
}