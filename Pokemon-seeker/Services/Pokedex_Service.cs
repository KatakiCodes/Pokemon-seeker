using System.Net;
using Newtonsoft.Json;
using Pokemon_seeker.Interfaces;
using Pokemon_seeker.Models;
using Pokemon_Seeker.Models;

namespace Pokemon_seeker.Services;

public class Pokedex_Service : IPokedex_Service
{
    private HttpClient _httpClient;
    public Pokedex_Service()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v1/");
    }
    public async Task<ResponseModel> GetPokemonAsync(string slug)
    {
        var response = await _httpClient.GetAsync($"pokemon/{slug}");
        var responseModel = new ResponseModel(response.StatusCode);

        if(ValidateResponse(responseModel,response) == true)
        {
            string readStringJson = await response.Content.ReadAsStringAsync();
            Pokemon pokemonResult = JsonConvert.DeserializeObject<Pokemon>(readStringJson);     
            responseModel.Pokemon = pokemonResult;
        }
        return responseModel;
    }
    private bool ValidateResponse(ResponseModel responseModel,HttpResponseMessage responseMessage)
    {
        if(responseMessage.IsSuccessStatusCode == false)
        {
            if(responseMessage.StatusCode == HttpStatusCode.NotFound)
                responseModel.Message = "Pokémon não localizado";
            else
                responseModel.Message = "Erro inesperado";
            return false;
        }
        else
            return true;
    }
}
