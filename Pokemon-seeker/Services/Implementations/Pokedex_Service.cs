using Pokemon_seeker.Services.Interfaces;

namespace Pokemon_seeker.Services.Implementations;

public class Pokedex_Service : IPokedex_Service
{
    private HttpClient _httpClient;
    public Pokedex_Service()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
    }
    public async Task<HttpResponseMessage> GetPokemonAsync(string slug)
    {
        var response = await _httpClient.GetAsync($"pokemon-species/{slug}");
        return response;
    }
}
