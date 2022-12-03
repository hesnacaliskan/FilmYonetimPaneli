using FilmYonetimPaneli.Application.Repositories.Movies;
using FilmYonetimPaneli.Application.ViewModels.Movie;
using FilmYonetimPaneli.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FilmYonetimPaneli.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        readonly private IMovieWriteRepository _movieWriteRepository;
        readonly private IMovieReadRepository _movieReadRepository;
        public MovieController(IMovieWriteRepository movieWriteRepository, IMovieReadRepository movieReadRepository)
        {
            _movieWriteRepository = movieWriteRepository;
            _movieReadRepository = movieReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok( _movieReadRepository.GetAll()); 
        }  
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Film film = await _movieReadRepository.GetByIdAsync(id);
            return Ok(film);
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Movie model)
        {
            await _movieWriteRepository.AddAsync(new()
            {
                filmAd = model.filmAd,
                filmYapimYil = model.filmYapimYil,
            }); 
            await _movieWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Movie model)
        {
            Film film = await _movieReadRepository.GetByIdAsync(model.Id);
            film.filmAd = model.filmAd;
            film.filmYapimYil = model.filmYapimYil;
            await _movieWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _movieWriteRepository.RemoveAsync(id);
            await _movieWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
