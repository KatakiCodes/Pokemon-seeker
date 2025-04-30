using System;
using System.Net;
using System.Text.Json.Serialization;

namespace Pokemon_seeker.Presentation.ViewModels;

public class PokemonViewModel : BaseResponseModel
{
    //Contructor to report failures
    public PokemonViewModel(bool succeeded, HttpStatusCode statusCode)
    : base(succeeded,statusCode)
    {}
    //Contructor to report success
    public PokemonViewModel(bool succeeded, HttpStatusCode statusCode, Object pokemonObject)
    : base(succeeded,statusCode)
    {
        PokemonObject = pokemonObject;
    }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Object? PokemonObject { get; set; }
}
