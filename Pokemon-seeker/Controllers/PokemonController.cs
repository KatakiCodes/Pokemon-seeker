using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokemon_seeker.Interfaces;
using Pokemon_seeker.Models;
using Pokemon_Seeker.Models;


namespace Pokemon_seeker.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokedex_Service _pokedex_Service;
        public PokemonController([FromServices]IPokedex_Service pokedex_Service)
        {
            _pokedex_Service = pokedex_Service;
        }
        [HttpGet("{slug}")]
        [ProducesResponseType(typeof(ResponseModel),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ResponseModel>> GetPokemon([FromRoute] string slug)
        {
            var pokemonResult = await _pokedex_Service.GetPokemonAsync(slug);
            return StatusCode((int)pokemonResult.HttpStatusCode,pokemonResult);
        }
    }
}
