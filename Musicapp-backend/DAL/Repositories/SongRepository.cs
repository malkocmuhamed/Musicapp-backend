using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.Models;
using Musicapp_backend.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Musicapp_backend.DAL.Repositories
{
    public class SongRepository: ISongRepository
    {
        musicappDBContext _context;

        public SongRepository(musicappDBContext context)
        {
            this._context = context;
        }

        public async Task CreateSong(Song song)
        {
            _context.Songs.Add(song);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return _context.Songs;
        }

        public async Task EditSong(Song song)
        {
            _context.Songs.Update(song);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSong(Song song)
        {
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
        }

        public async Task<Song> GetSongById(int id)
        {
            return await _context.Songs.SingleOrDefaultAsync(c => c.SongId == id);
        }




    }
}
