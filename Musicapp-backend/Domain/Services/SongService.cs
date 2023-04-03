using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.DAL.Interfaces;
using Musicapp_backend.Domain.Interfaces;
using Musicapp_backend.Models;

namespace Musicapp_backend.Domain.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            this._songRepository = songRepository;
        }

        public Task CreateSong(Song song)
        {
            return _songRepository.CreateSong(song);
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return _songRepository.GetAllSongs();
        }

        public Task EditSong(Song songInDB, Song song)
        {
            songInDB.SongName = song.SongName;
            songInDB.SongArtist = song.SongArtist;
            songInDB.SongUrl = song.SongUrl;
            songInDB.SongRating = song.SongRating;
            songInDB.IsFavourite = song.IsFavourite;
            songInDB.CategoryId = song.CategoryId;
            songInDB.EditedDate = DateTime.Now;
            return _songRepository.EditSong(songInDB);
        }

        public Task DeleteSong(Song song)
        {
            return _songRepository.DeleteSong(song);
        }

        public Task<Song> GetSongById(int id)
        {
            return _songRepository.GetSongById(id);
        }


    }
}
