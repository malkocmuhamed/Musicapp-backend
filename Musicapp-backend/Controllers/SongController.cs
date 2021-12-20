using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.Models;
using Musicapp_backend.Domain.Interfaces;

namespace Musicapp_backend.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            this._songService = songService;
        }

        //GET api/<SongsController>/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSongById(int id)
        {
            Song songInDB = await _songService.GetSongById(id);
            if (songInDB == null)
            {
                return NotFound();
            }
            return Ok(await _songService.GetSongById(id));
        }

        //POST api/<SongsController>
        [HttpPost]

        public async Task<IActionResult> CreateSong(Song song)
        {
            await _songService.CreateSong(song);
            return CreatedAtAction(nameof(GetSongById), new { id = song.SongId }, song);
        }

        //GET api/<SongsController>
        [HttpGet]
        public IActionResult GetAllSongs()
        {
            return Ok(_songService.GetAllSongs());
        }

        // PUT api/<SongsController>
        [HttpPut]
        public async Task<IActionResult> EditSong(Song song)
        {
            Song songInDB = await _songService.GetSongById(song.SongId);
            if (songInDB == null)
            {
                return NotFound();
            }
            await _songService.EditSong(songInDB, song);
            return Ok();
        }

        // DELETE api/<SongsController>/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSong(int id)
        {
            Song songInDB = await _songService.GetSongById(id);
            if (songInDB == null)
            {
                return NotFound();
            }
            await _songService.DeleteSong(songInDB);
            return Ok();
        }
       
    }
}
