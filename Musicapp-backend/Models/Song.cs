using System;
using System.Collections.Generic;

#nullable disable

namespace Musicapp_backend.Models
{
    public partial class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string SongUrl { get; set; }
        public int? SongRating { get; set; }
        public string IsFavourite { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
