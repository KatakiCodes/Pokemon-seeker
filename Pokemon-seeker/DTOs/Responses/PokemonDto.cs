using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Pokemon_seeker.DTOs.Responses;

public class PokemonDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public int Gender_rate { get; set; }
    public int Capture_rate { get; set; }
    public int Base_happiness { get; set; }
    public bool Is_baby { get; set; }
    public bool Is_legendary { get; set; }
    public bool Is_mythical { get; set; }
    public int Hatch_counter { get; set; }
    public bool Has_gender_differences { get; set; }
    public bool Forms_switchable { get; set; }
}
