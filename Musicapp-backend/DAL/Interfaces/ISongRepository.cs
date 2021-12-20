using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.Models;

namespace Musicapp_backend.DAL.Interfaces
{
    public interface ISongRepository
    {
        public IEnumerable<Song> GetAllSongs();

        public Task CreateSong(Song song);

        public Task<Song> GetSongById(int id);

        public Task EditSong(Song song);

        public Task DeleteSong(Song song);

    }
}
