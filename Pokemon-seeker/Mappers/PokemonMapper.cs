using System;
using Pokemon_seeker.DataAccess.Entities;
using Pokemon_seeker.DTOs.Responses;

namespace Pokemon_seeker.Mappers;

public static class PokemonMapper
{
    public static PokemonDto ToDto(this PokemonDto pokemonDto, Pokemon pokemon)
    {
        return new PokemonDto
        {
            Id = pokemon.Id,
            Name = pokemon.Name,
            Order = pokemon.Order,
            Gender_rate = pokemon.Gender_rate,
            Capture_rate = pokemon.Capture_rate,
            Base_happiness = pokemon.Base_happiness,
            Is_baby = pokemon.Is_baby,
            Is_legendary = pokemon.Is_legendary,
            Is_mythical = pokemon.Is_mythical,
            Hatch_counter = pokemon.Hatch_counter,
            Has_gender_differences = pokemon.Has_gender_differences,
            Forms_switchable = pokemon.Forms_switchable,
        };
    }
}
