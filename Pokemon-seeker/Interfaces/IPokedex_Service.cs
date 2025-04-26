using System;
using Pokemon_seeker.Models;

namespace Pokemon_seeker.Interfaces;

public interface IPokedex_Service
{
    public Task<ResponseModel> GetPokemonAsync(string slug);
}
