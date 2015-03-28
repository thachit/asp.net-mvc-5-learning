using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseIfModelChanges<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Title = "Caravan",
                Price = 9.99m
            });
            base.Seed(context);
        }
    }
}