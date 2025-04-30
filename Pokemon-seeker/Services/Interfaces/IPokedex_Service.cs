using System;

namespace Pokemon_seeker.Services.Interfaces;

public interface IPokedex_Service
{
    public Task<HttpResponseMessage> GetPokemonAsync(string slug);
}
