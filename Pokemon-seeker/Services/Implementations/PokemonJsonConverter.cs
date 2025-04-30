using System;
using Newtonsoft.Json;
using Pokemon_seeker.DataAccess.Entities;
using Pokemon_seeker.Services.Interfaces;

namespace Pokemon_seeker.Services.Implementations;

public class PokemonJsonConverter : IPokemonJsonConverter
{
    public async Task<Pokemon> ToObject(HttpResponseMessage response)
    {
        //GET CONTENT FROM RESPONSE_MESSAGE
        //Convert the content of response_message to string
        string JsonString = await response.Content.ReadAsStringAsync();
        //Serialize the content of response_message (Pokemon Json)
        var pokemonObject = JsonConvert.DeserializeObject<Pokemon>(JsonString);
        return pokemonObject;
    }
}
