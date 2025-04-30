using System;
using Pokemon_seeker.DataAccess.Entities;

namespace Pokemon_seeker.Services.Interfaces;

public interface IPokemonJsonConverter
{
    public Task<Pokemon> ToObject(HttpResponseMessage response);
}
