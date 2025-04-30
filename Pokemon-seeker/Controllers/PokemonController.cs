using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokemon_seeker.DTOs.Responses;
using Pokemon_seeker.Mappers;
using Pokemon_seeker.Presentation.ViewModels;
using Pokemon_seeker.Services.Implementations;
using Pokemon_seeker.Services.Interfaces;


namespace Pokemon_seeker.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokedex_Service _pokedex_Service;
        public PokemonController(
            [FromServices]IPokemonJsonConverter pokemonJsonConverter,
            IPokedex_Service pokedex_Service
        )
        {
            _pokedex_Service = pokedex_Service;
        }
        [HttpGet("{slug}")]
        [ProducesResponseType(typeof(BaseResponseModel),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<BaseResponseModel>> GetPokemon([FromRoute] string slug)
        {
            PokemonViewModel pokemonView;

            //Get response from request
            HttpResponseMessage responseMessage = await _pokedex_Service.GetPokemonAsync(slug);
            //get status code
            var statusCode = responseMessage.StatusCode;
            // Get success result
            var succeeded = responseMessage.IsSuccessStatusCode;
            //Build error pokemon_view_model
            if(!succeeded)
                pokemonView = new PokemonViewModel(succeeded,statusCode);
            else
            {
                //Serialize response_message content
                var pokemonObject = await new PokemonJsonConverter().ToObject(responseMessage);
                //Convert the Pokemon object to DTO
                var pokemonDtodto = new PokemonDto().ToDto(pokemonObject);
                pokemonView = new PokemonViewModel(succeeded,statusCode,pokemonDtodto);
            }
            return StatusCode((int)statusCode,pokemonView);
        }
    }
}
