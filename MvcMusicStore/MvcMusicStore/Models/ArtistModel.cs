using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace mvcMusicStore.Models
{
    public class Artist
    {
        [DisplayName("Atirst")]
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}