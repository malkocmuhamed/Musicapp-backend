using System;
using System.Collections.Generic;

#nullable disable

namespace Musicapp_backend.Models
{
    public partial class Category
    {
        public Category()
        {
            Songs = new List<Song>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Song> Songs { get; set; }
    }
}
